namespace RockHopper.Test.IntTest.Support;

public class TwoNumbersClassFixture : IClassFixture
{
    public int FirstValue { get; private set; }
    
    public int SecondValue { get; private set; }
    
    public Task ExecuteAsync()
    {
        FirstValue = 101;
        SecondValue = 202;
        return Task.CompletedTask;
    }
    
    public ValueTask DisposeAsync()
    {
        return ValueTask.CompletedTask;
    }
}