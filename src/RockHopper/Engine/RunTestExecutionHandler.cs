using System.Reflection;
using Microsoft.Testing.Platform.Configurations;
using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.Testing.Platform.Extensions.TestFramework;
using RockHopper.Engine.Fixtures;
using RockHopper.Extensions;

namespace RockHopper.Engine;

internal sealed class RunTestExecutionHandler : TestExecutionHandler
{
    private readonly MessageContext _messageContext;
    private readonly IServiceProvider _provider;
    private readonly IConfiguration _configuration;
    private readonly Assembly[] _assemblies;

    internal RunTestExecutionHandler(
        MessageContext messageContext,
        IDataProducer dataProducer, 
        ExecuteRequestContext context,
        IServiceProvider provider,
        IConfiguration configuration,
        params Assembly[] assemblies) 
        : base(dataProducer, context)
    {
        _messageContext = messageContext;
        _provider = provider;
        _configuration = configuration;
        _assemblies = assemblies;
    }

    internal async Task HandleAsync()
    {
        try
        {
            var testNodes = TestNodeFactory.Create(_assemblies);

            var assemblyFixtures = await AssemblyFixtures.BuildAsync(_provider);

            var sharedFixtureInfoList = await SharedFixtures.BuildAsync(testNodes, _provider);

            var groupedTestNodes = testNodes.GroupBy(n => n.TestClassType);

            var configuration = new TestConfigurationProvider(_configuration);
            
            // TODO: Handle cancel of test run
            var parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = 1 };

            await Parallel.ForEachAsync(groupedTestNodes, parallelOptions, async (groupedTestNode, ct) =>
            {
                var fixtureAttribute = groupedTestNode.Key.GetCustomAttribute<FixtureAttribute>();

                var classFixture = await ClassFixtures.BuildAsync(_provider, fixtureAttribute?.Class);

                foreach (var initialTestNode in groupedTestNode)
                {
                    if (initialTestNode.IsSkipped)
                    {
                        var skippedTestNode = initialTestNode.TransitionToSkipped(initialTestNode.SkipMessage ?? "Test has been skipped");
                        await PublishAsync(skippedTestNode);
                        continue;
                    }

                    var testNodeInProgress = initialTestNode.TransitionToInProgress();

                    await PublishAsync(testNodeInProgress);

                    var testOutput = new TestOutput();

                    try
                    {
                        var sharedFixtures = SharedFixtures.Filter(sharedFixtureInfoList, testNodeInProgress.TestClassType);
                        var executionContext = new ExecutionContext(
                            classFixture, sharedFixtures, assemblyFixtures, testOutput, configuration, _provider, ct);
                        await testNodeInProgress.ExecuteTestAsync(executionContext);
                        var testNodePassed = testNodeInProgress.TransitionToPassed();
                        testOutput.AppendToTestNode(testNodePassed);
                        await PublishAsync(testNodePassed);
                    }
                    catch (TargetInvocationException error) when (error.InnerException is not null)
                    {
                        var testNodeFailed = testNodeInProgress.TransitionToFailed(error.InnerException);
                        testOutput.AppendToTestNode(testNodeFailed);
                        await PublishAsync(testNodeFailed);
                    }
                    catch (Exception error)
                    {
                        var testNodeFailed = testNodeInProgress.TransitionToFailed(error);
                        testOutput.AppendToTestNode(testNodeFailed);
                        await PublishAsync(testNodeFailed);
                    }
                }

                if (classFixture is not null)
                    await classFixture.Dispose();
            });

            await SharedFixtures.DisposeAsync(sharedFixtureInfoList);

            await AssemblyFixtures.DisposeAsync(assemblyFixtures);
        }
        catch (Exception error)
        {
            await _messageContext.WriteFailedMessageAsync("Unexpected error occurred running the tests:");
            await _messageContext.WriteFailedMessageAsync(error.ToString());
        }
        finally
        {
            Complete();
        }
    }
}