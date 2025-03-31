using RockHopper;

namespace TestBed;

public sealed class TestAssemblyFixture : IAssemblyFixture
{
    private readonly int _id = Random.Shared.Next();

    public TestAssemblyFixture(IAssemblySetup assemblySetup)
    {
        assemblySetup.Run();
    }
    
    public void DoSomething()
    {
        Console.WriteLine("Calling Assembly Fixture DoSomething: " + _id);
    }
    
    public Task ExecuteAsync()
    {
        Console.WriteLine("My Assembly Fixture: " + _id);
        return Task.CompletedTask;
    }
    
    public ValueTask DisposeAsync()
    {
        Console.WriteLine("Dispose Assembly Fixture: " + _id);
        return ValueTask.CompletedTask;
    }
}

public interface IAssemblySetup
{
    void Run();
}

public sealed class AssemblySetup : IAssemblySetup
{
    public void Run()
    {
        Console.WriteLine("Running assembly dependency setup.");
    }
}

public interface ITestSetup
{
    void Run();
}

public sealed class TestSetup : ITestSetup
{
    public void Run()
    {
        Console.WriteLine("Running test dependency setup.");
    }
}