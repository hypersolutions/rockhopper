using Microsoft.Testing.Platform.Extensions.OutputDevice;
using Microsoft.Testing.Platform.OutputDevice;
using RockHopper.Test.Extensions;

namespace RockHopper.Test.Engine;

internal sealed class MessageContext
{
    private readonly IOutputDeviceDataProducer _dataProducer;
    private readonly IOutputDevice _outputDevice;

    public MessageContext(IOutputDeviceDataProducer dataProducer, IOutputDevice outputDevice)
    {
        _dataProducer = dataProducer;
        _outputDevice = outputDevice;
    }

    internal Task WriteSuccessMessageAsync(string message) 
        => _outputDevice.WriteSuccessMessageAsync(_dataProducer, message);
    
    internal Task WriteFailedMessageAsync(string message) 
        => _outputDevice.WriteFailedMessageAsync(_dataProducer, message);
    
    internal Task WriteMessageAsync(string message) 
        => _outputDevice.WriteMessageAsync(_dataProducer, message);
}