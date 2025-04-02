using RockHopper.Assertions;
using RockHopper.Assertions.Exceptions;

namespace RockHopper.Test.Assertions;

public class ShouldTests
{
    [Test]
    public void ActionThatThrowsError_Throw_ReturnsException()
    {
        var exception = Should.Throw<Exception>(Action);
        
        exception.Message.ShouldBe("Test exception");
        return;

        void Action() => throw new Exception("Test exception");
    }
    
    [Test]
    public void ActionThatThrowsUnexpectedError_Throw_ThrowsNotThrownException()
    {
        try
        {
            Should.Throw<ArgumentException>(Action);
        }
        catch (Exception error) when (error is ExpectedErrorNotThrownException<ArgumentException>)
        {
            // Passed
        }
        
        return;

        void Action() => throw new InvalidOperationException("Test exception");
    }
}