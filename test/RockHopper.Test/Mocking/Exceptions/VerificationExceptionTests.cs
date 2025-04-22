using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;

namespace RockHopper.Test.Mocking.Exceptions;

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