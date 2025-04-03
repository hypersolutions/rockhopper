# Hooks

Before all the tests are run and after all the tests have run, you can run hooks. You can register as many as you need via the
_services_. It doesn't matter if they are registered as _transient_ or _singleton_ - each will be resolved and run once. It also 
means that dependencies can be injected into your hooks - if required.

A simple pre-test hook might look like:

```c#
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
```

and a post-test hook uses the same pattern:

```c#
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
```

Register these as services in the _Program.cs_ class:

```c#
var builder = RockHopperTestApplicationBuilder
    .CreateBuilder(args)
    .AddTestingFramework<Program>()
    .AddSingleton<IPreTestHook, PreTestHook>()
    .AddSingleton<IPostTestHook, PostTestHook>();
```