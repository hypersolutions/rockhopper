namespace RockHopper.IntTest.Support;

public class TwoNumbersSharedFixture : ISharedFixture
{
    public TwoNumbersSharedFixture()
    {
        ConstructorCount++;
    }
    
    public int FirstValue { get; private set; }
    
    public int SecondValue { get; private set; }

    public static int ConstructorCount { get; private set; }
    
    public Task ExecuteAsync()
    {
        FirstValue = 501;
        SecondValue = 502;
        return Task.CompletedTask;
    }
    
    public ValueTask DisposeAsync()
    {
        return ValueTask.CompletedTask;
    }
}