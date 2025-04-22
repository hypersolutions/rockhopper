using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;
using RockHopper.Mocking.Setup;

namespace RockHopper.Test.Mocking.Setup;

public class ExceptionListTests 
{
    private readonly ExceptionList _exceptionList = new();
    
    [Fact]
    public void AddingSingleException_GetNext_ReturnsValue()
    {
        var testException = new Exception();
        _exceptionList.Add(testException);
        
        var value = _exceptionList.GetNext();

        value.ShouldBe(testException);
    }
    
    [Fact]
    public void NoExceptions_GetNext_ReturnsNull()
    {
        var exception = Should.Throw<MockException>(() => _exceptionList.GetNext());

        exception.Message.ShouldBe("The exception sequence exceeds the request.");
    }
    
    [Fact]
    public void PastLastException_GetNext_ThrowsException()
    {
        _exceptionList.Add(new Exception());
        _ = _exceptionList.GetNext();

        var exception = Should.Throw<MockException>(() => _exceptionList.GetNext());
        
        exception.Message.ShouldBe("The exception sequence exceeds the request.");
    }
}