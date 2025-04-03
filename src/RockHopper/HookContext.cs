using Microsoft.Testing.Platform.Extensions.OutputDevice;
using Microsoft.Testing.Platform.OutputDevice;

namespace RockHopper;

/// <summary>
/// Defines the hook context info.
/// </summary>
public sealed class HookContext
{
    internal HookContext(IOutputDeviceDataProducer dataProducer, IOutputDevice outputDevice)
    {
        DataProducer = dataProducer;
        OutputDevice = outputDevice;
    }
    
    /// <summary>
    /// Gets the hook data producer - useful for logging to the output device.
    /// </summary>
    public IOutputDeviceDataProducer DataProducer { get; }

    /// <summary>
    /// Gets the output device.
    /// </summary>
    public IOutputDevice OutputDevice { get; }

    /// <summary>
    /// Logs a message to the output device.
    /// </summary>
    /// <param name="message">Message to log</param>
    /// <param name="color">Color to format message as</param>
    /// <returns>Task to await</returns>
    public Task LogMessageAsync(string message, ConsoleColor color)
    {
        return OutputDevice.DisplayAsync(DataProducer, new FormattedTextOutputDeviceData(message)
        {
            ForegroundColor = new SystemConsoleColor { ConsoleColor = color }
        });
    }
}