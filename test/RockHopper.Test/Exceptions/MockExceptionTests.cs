using RockHopper.Assertions;
using RockHopper.Exceptions;

namespace RockHopper.Test.Exceptions;

public class MockExceptionTests 
{
    [Test]
    public void WithMessage_Ctor_SetsErrorMessage()
    {
        const string message = "Test error";
        
        var exception = new MockException(message);
        
        exception.Message.ShouldBe(message);
    }
    
    [Test]
    public void WithMessageAndException_Ctor_SetsErrorMessage()
    {
        const string message = "Test error";
        var innerException = new Exception("Inner test error");
        
        var exception = new MockException(message, innerException);
        
        exception.Message.ShouldBe(message);
    }
    
    [Test]
    public void WithMessageAndException_Ctor_SetsInnerException()
    {
        const string message = "Test error";
        var innerException = new Exception("Inner test error");
        
        var exception = new MockException(message, innerException);
        
        exception.InnerException.ShouldBe(innerException);
    }
}