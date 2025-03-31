using System.Reflection;
using RockHopper.Engine.TestNodes;
using RockHopper.Extensions;

namespace RockHopper.Engine;

internal sealed class TestNodeExecutor
{
    private readonly PlatformTestNode _testNode;

    public TestNodeExecutor(PlatformTestNode testNode)
    {
        _testNode = testNode;
    }
    
    internal async Task ExecuteTestAsync(ExecutionContext context)
    {
        object? testClassInstance = null;
        
        try
        {
            TestContext.InitCurrent(context.ServiceProvider, context.TestOutput, context.Configuration, context.CancellationToken);

            if (context.ClassFixture is not null)
            {
                TestContext.AddFixture(context.ClassFixture);
            }

            var fixtureAttribute = _testNode.TestClassType.GetCustomAttribute<FixtureAttribute>();

            if (fixtureAttribute?.Shared is not null)
            {
                TestContext.AddFixture(context.GetSharedFixture(fixtureAttribute.Shared));
            }

            foreach (var assemblyFixture in context.AssemblyFixtures)
            {
                TestContext.AddFixture(assemblyFixture);
            }
            
            testClassInstance = Activator.CreateInstance(_testNode.TestClassType);

            var args = _testNode.Args?.Length > 0 ? _testNode.Args : [];
            
            if (_testNode.IsAwaitable)
            {
                await (Task)_testNode.Method.Invoke(testClassInstance, args)!;
            }
            else
            {
                _testNode.Method.Invoke(testClassInstance, args);
            }
        }
        finally
        {
            TestContext.VerifyAll();

            if (testClassInstance is not null)
            {
                await testClassInstance.Dispose();
            }
        }
    }
}