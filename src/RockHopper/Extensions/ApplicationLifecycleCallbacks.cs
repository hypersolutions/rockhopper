using Microsoft.Extensions.DependencyInjection;
using Microsoft.Testing.Platform.Extensions;
using Microsoft.Testing.Platform.Extensions.OutputDevice;
using Microsoft.Testing.Platform.Extensions.TestHost;
using Microsoft.Testing.Platform.OutputDevice;

#pragma warning disable TPEXP

namespace RockHopper.Extensions;

internal sealed class ApplicationLifecycleCallbacks : ITestApplicationLifecycleCallbacks, IOutputDeviceDataProducer
{
    private readonly IExtension _extension;
    private readonly IOutputDevice _outputDevice;
    private readonly IServiceProvider _serviceProvider;
    
    internal ApplicationLifecycleCallbacks(IExtension extension, IOutputDevice outputDevice, IServiceProvider serviceProvider)
    {
        _extension = extension;
        _outputDevice = outputDevice;
        _serviceProvider = serviceProvider;
    }

    public string Uid => _extension.Uid;

    public string Version => _extension.Version;

    public string DisplayName => _extension.DisplayName;

    public string Description => _extension.Description;

    public async Task BeforeRunAsync(CancellationToken cancellationToken)
    {
        await LogMessageAsync("RockHopper will run any registered pre-test hooks...");

        var preTestHooks = _serviceProvider.GetServices<IPreTestHook>();
        HookContext? context = null;
        
        foreach (var preTestHook in preTestHooks)
        {
            context ??= new HookContext(this, _outputDevice);
            await preTestHook.ExecuteAsync(context);
        }
        
        await LogMessageAsync("Pre-test hooks complete.");
    }

    public async Task AfterRunAsync(int exitCode, CancellationToken cancellation)
    {
        await LogMessageAsync("RockHopper will run any registered post-test hooks...");

        var postTestHooks = _serviceProvider.GetServices<IPostTestHook>();
        HookContext? context = null;

        foreach (var postTestHook in postTestHooks)
        {
            context ??= new HookContext(this, _outputDevice);
            await postTestHook.ExecuteAsync(context);
        }
        
        await LogMessageAsync("Post-test hooks complete.");

        var color = exitCode != 0 ? ConsoleColor.DarkRed : ConsoleColor.DarkGreen;
        await LogMessageAsync($"RockHopper exited with exit code: {exitCode}", color);
    }

    public Task<bool> IsEnabledAsync()
    {
        return _extension.IsEnabledAsync();
    }

    private Task LogMessageAsync(string message, ConsoleColor color = ConsoleColor.DarkGreen)
    {
        return _outputDevice.DisplayAsync(this, new FormattedTextOutputDeviceData(message)
        {
            ForegroundColor = new SystemConsoleColor { ConsoleColor = color }
        });
    }
}