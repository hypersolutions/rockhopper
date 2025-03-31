using RockHopper.Assertions;
using RockHopper.Exceptions;

namespace RockHopper.Test.Exceptions;

public class VerificationExceptionTests 
{
    [Test]
    public void WithMessage_Ctor_SetsErrorMessage()
    {
        const string message = "Test error";
        
        var exception = new VerificationException(message);
        
        exception.Message.ShouldBe(message);
    }
}