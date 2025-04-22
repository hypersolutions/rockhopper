using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;

namespace RockHopper.Test.Mocking.Exceptions;

public class MockExceptionTests 
{
    [Fact]
    public void WithMessage_Ctor_SetsErrorMessage()
    {
        const string message = "Test error";
        
        var exception = new MockException(message);
        
        exception.Message.ShouldBe(message);
    }
    
    [Fact]
    public void WithMessageAndException_Ctor_SetsErrorMessage()
    {
        const string message = "Test error";
        var innerException = new Exception("Inner test error");
        
        var exception = new MockException(message, innerException);
        
        exception.Message.ShouldBe(message);
    }
    
    [Fact]
    public void WithMessageAndException_Ctor_SetsInnerException()
    {
        const string message = "Test error";
        var innerException = new Exception("Inner test error");
        
        var exception = new MockException(message, innerException);
        
        exception.InnerException.ShouldBe(innerException);
    }
}