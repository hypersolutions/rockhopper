using Microsoft.Testing.Platform.Extensions.OutputDevice;
using Microsoft.Testing.Platform.OutputDevice;
using RockHopper;

namespace TestBed;

public class PreTestHook : IPreTestHook
{
    public async Task ExecuteAsync(IOutputDeviceDataProducer dataProducer, IOutputDevice outputDevice)
    {
        await outputDevice.DisplayAsync(dataProducer, new FormattedTextOutputDeviceData("My Pre-test hook")
        {
            ForegroundColor = new SystemConsoleColor { ConsoleColor = ConsoleColor.DarkCyan }
        });
    }
}

public class PostTestHook : IPostTestHook
{
    public async Task ExecuteAsync(IOutputDeviceDataProducer dataProducer, IOutputDevice outputDevice)
    {
        await outputDevice.DisplayAsync(dataProducer, new FormattedTextOutputDeviceData("My Pre-test hook")
        {
            ForegroundColor = new SystemConsoleColor { ConsoleColor = ConsoleColor.DarkCyan }
        });
    }
}