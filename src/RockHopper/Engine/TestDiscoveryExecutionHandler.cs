using System.Reflection;
using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.Testing.Platform.Extensions.TestFramework;

namespace RockHopper.Engine;

internal sealed class TestDiscoveryExecutionHandler : TestExecutionHandler
{
    private readonly MessageContext _messageContext;
    private readonly Assembly[] _assemblies;

    internal TestDiscoveryExecutionHandler(
        MessageContext messageContext,
        IDataProducer dataProducer, 
        ExecuteRequestContext context,
        params Assembly[] assemblies) 
        : base(dataProducer, context)
    {
        _messageContext = messageContext;
        _assemblies = assemblies;
    }

    internal async Task HandleAsync()
    {
        try
        {
            var testNodes = TestNodeFactory.Create(_assemblies);

            foreach (var testNode in testNodes)
            {
                await PublishAsync(testNode);
            }
        }
        catch (Exception error)
        {
            await _messageContext.WriteFailedMessageAsync("Failed to discover tests:");
            await _messageContext.WriteFailedMessageAsync(error.ToString());
        }
        finally
        {
            Complete();
        }
    }
}