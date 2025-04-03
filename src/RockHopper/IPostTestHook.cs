using Microsoft.Testing.Platform.Extensions.OutputDevice;
using Microsoft.Testing.Platform.OutputDevice;

namespace RockHopper;

/// <summary>
/// Defines the contract for a post-test hook.
/// </summary>
public interface IPostTestHook
{
    /// <summary>
    /// Executes the post-test hook.
    /// </summary>
    /// <param name="dataProducer">Data producer - useful for logging to the output device</param>
    /// <param name="outputDevice">Output device</param>
    /// <returns>Task</returns>
    Task ExecuteAsync(IOutputDeviceDataProducer dataProducer, IOutputDevice outputDevice);
}