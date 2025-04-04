using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.Testing.Platform.Extensions.TestFramework;
using RockHopper.Engine.Filtering;
using RockHopper.Engine.TestNodes;

namespace RockHopper.Engine;

internal abstract class TestExecutionHandler
{
    private readonly IDataProducer _dataProducer;
    private readonly ExecuteRequestContext _context;

    protected TestExecutionHandler(IDataProducer dataProducer, ExecuteRequestContext context)
    {
        _dataProducer = dataProducer;
        _context = context;
    }

    protected TestFilter Filter => TestFilter.GetTestFilter(_context);
    
    protected async Task PublishAsync(PlatformTestNode testNode)
    {
        var data = new TestNodeUpdateMessage(_context.Request.Session.SessionUid, testNode);
        await _context.MessageBus.PublishAsync(_dataProducer, data);
    }

    protected void Complete()
    {
        _context.Complete();
    }
}