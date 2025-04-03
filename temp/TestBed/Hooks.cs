using RockHopper;

namespace TestBed;

public class PreTestHook : IPreTestHook
{
    public async Task ExecuteAsync(HookContext context)
    {
        await context.LogMessageAsync("My Pre-test hook", ConsoleColor.DarkGreen);
    }
}

public class PostTestHook : IPostTestHook
{
    public async Task ExecuteAsync(HookContext context)
    {
        await context.LogMessageAsync("My Post-test hook", ConsoleColor.DarkGreen);
    }
}