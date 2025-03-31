using RockHopper;

namespace TestBed;

public sealed class TestClassFixture : IClassFixture
{
    private readonly int _id = Random.Shared.Next();
    
    public void DoSomething()
    {
        Console.WriteLine("Calling Class Fixture DoSomething: " + _id);
    }
    
    public Task ExecuteAsync()
    {
        Console.WriteLine("My Class Fixture: " + _id);
        return Task.CompletedTask;
    }
    
    public ValueTask DisposeAsync()
    {
        Console.WriteLine("Dispose Class Fixture: " + _id);
        return ValueTask.CompletedTask;
    }
}