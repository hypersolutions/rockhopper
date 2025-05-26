using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;
using RockHopper.Mocking.Setup;

namespace RockHopper.Test.Mocking.Setup;

public class ReturnValueListTests 
{
    private readonly ReturnValueList _returnValueList = new();
    
    [Fact]
    public void AddingSingleValue_GetNext_ReturnsValue()
    {
        _returnValueList.Add(10);
        
        var value = _returnValueList.GetNext();
        
        value.ShouldBe(10);
    }
    
    [Fact]
    public void NoValues_GetNext_ReturnsNull()
    {
        var value = _returnValueList.GetNext();

        value.ShouldBeNull();
    }
    
    [Fact]
    public void PastLastValue_GetNext_ThrowsException()
    {
        _returnValueList.Add(10);
        _ = _returnValueList.GetNext();

        var exception = Should.Throw<MockException>(() => _returnValueList.GetNext());
        
        exception.Message.ShouldBe("The return value sequence exceeds the request.");
    }
}