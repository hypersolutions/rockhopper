using Microsoft.Testing.Platform.Extensions.OutputDevice;
using Microsoft.Testing.Platform.OutputDevice;

namespace RockHopper.Test.Extensions;

internal static class OutputDeviceExtensions
{
    internal static async Task WriteSuccessMessageAsync(
        this IOutputDevice outputDevice, 
        IOutputDeviceDataProducer dataProducer, 
        string message)
    {
        await outputDevice.DisplayAsync(dataProducer, new FormattedTextOutputDeviceData(message)
        {
            ForegroundColor = new SystemConsoleColor { ConsoleColor = ConsoleColor.DarkGreen }
        });
    }
    
    internal static async Task WriteFailedMessageAsync(
        this IOutputDevice outputDevice, 
        IOutputDeviceDataProducer dataProducer, 
        string message)
    {
        await outputDevice.DisplayAsync(dataProducer, new FormattedTextOutputDeviceData(message)
        {
            ForegroundColor = new SystemConsoleColor { ConsoleColor = ConsoleColor.DarkRed }
        });
    }
    
    internal static async Task WriteMessageAsync(
        this IOutputDevice outputDevice, 
        IOutputDeviceDataProducer dataProducer, 
        string message)
    {
        await outputDevice.DisplayAsync(dataProducer, new TextOutputDeviceData(message));
    }
}