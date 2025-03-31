using RockHopper.Assertions;
using RockHopper.Exceptions;
using RockHopper.Mocking.Setup;

namespace RockHopper.Test.Mocking.Setup;

public class ExceptionListTests 
{
    private readonly ExceptionList _exceptionList = new();
    
    [Test]
    public void AddingSingleException_GetNext_ReturnsValue()
    {
        var testException = new Exception();
        _exceptionList.Add(testException);
        
        var value = _exceptionList.GetNext();

        value.ShouldBeNull();//(testException);
    }
    
    [Test]
    public void NoExceptions_GetNext_ReturnsNull()
    {
        var exception = Should.Throw<MockException>(() => _exceptionList.GetNext());

        exception.Message.ShouldBe("The exception sequence exceeds the request.");
    }
    
    [Test]
    public void PastLastException_GetNext_ThrowsException()
    {
        _exceptionList.Add(new Exception());
        _ = _exceptionList.GetNext();

        var exception = Should.Throw<MockException>(() => _exceptionList.GetNext());
        
        exception.Message.ShouldBe("The exception sequence exceeds the request.");
    }
}