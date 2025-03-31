namespace RockHopper.IntTest.Support;

public class TwoNumbersAssemblyFixture : IAssemblyFixture
{
    public TwoNumbersAssemblyFixture()
    {
        ConstructorCount++;
    }
    
    public int FirstValue { get; private set; }
    
    public int SecondValue { get; private set; }

    public static int ConstructorCount { get; private set; }
    
    public Task ExecuteAsync()
    {
        FirstValue = 5001;
        SecondValue = 5002;
        return Task.CompletedTask;
    }
    
    public ValueTask DisposeAsync()
    {
        return ValueTask.CompletedTask;
    }
}