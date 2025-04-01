using RockHopper.Assertions;

namespace RockHopper.Test.Assertions;

public class ShouldBeBooleanTests : ShouldBaseTest
{
    [Test]
    public void TrueFlag_ShouldBeTrue_NotThrowException()
    {
        const bool actual = true;
        
        ShouldNotThrow<bool>(() => actual.ShouldBeTrue());
    }
    
    [Test]
    public void FalseFlag_ShouldBeFalse_NotThrowException()
    {
        const bool actual = false;
        
        ShouldNotThrow<bool>(() => actual.ShouldBeFalse());
    }
    
    [Test]
    public void FalseFlag_ShouldBeTrue_ThrowsException()
    {
        const bool actual = false;
        
        ShouldThrow(() => actual.ShouldBeTrue(), true, actual);
    }
    
    [Test]
    public void TrueFlag_ShouldBeFalse_ThrowsException()
    {
        const bool actual = true;
        
        ShouldThrow(() => actual.ShouldBeFalse(), false, actual);
    }
}