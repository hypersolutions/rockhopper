using RockHopper;

namespace TestBed;

public sealed class TestSharedFixture : ISharedFixture
{
    private readonly int _id = Random.Shared.Next();
    
    public void DoSomething()
    {
        Console.WriteLine("Calling Shared Fixture DoSomething: " + _id);
    }
    
    public Task ExecuteAsync()
    {
        Console.WriteLine("My Shared Fixture: " + _id);
        return Task.CompletedTask;
    }
    
    public ValueTask DisposeAsync()
    {
        Console.WriteLine("Dispose Shared Fixture: " + _id);
        return ValueTask.CompletedTask;
    }
}