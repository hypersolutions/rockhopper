using RockHopper.Assertions;
using RockHopper.Exceptions;
using RockHopper.Mocking.Setup;

namespace RockHopper.Test.Mocking.Setup;

public class ReturnValueListTests 
{
    private readonly ReturnValueList _returnValueList = new();
    
    [Test]
    public void AddingSingleValue_GetNext_ReturnsValue()
    {
        _returnValueList.Add(10);
        
        object? value = _returnValueList.GetNext();
        
        value.ShouldBe(10);
    }
    
    [Test]
    public void NoValues_GetNext_ReturnsNull()
    {
        object? value = _returnValueList.GetNext();

        value.ShouldBeNull();
    }
    
    [Test]
    public void PastLastValue_GetNext_ThrowsException()
    {
        _returnValueList.Add(10);
        _ = _returnValueList.GetNext();

        var exception = Should.Throw<MockException>(() => _returnValueList.GetNext());
        
        exception.Message.ShouldBe("The return value sequence exceeds the request.");
    }
}