using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;

namespace RockHopper.Mocking.Test.Exceptions;

public class VerificationExceptionTests 
{
    [Fact]
    public void WithMessage_Ctor_SetsErrorMessage()
    {
        const string message = "Test error";
        
        var exception = new VerificationException(message);
        
        exception.Message.ShouldBe(message);
    }
}