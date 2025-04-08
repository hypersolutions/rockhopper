namespace RockHopper.Assertions.Test;

public class ShouldBeBooleanTests : ShouldBaseTest
{
    [Fact]
    public void TrueFlag_ShouldBeTrue_NotThrowException()
    {
        const bool actual = true;
        
        ShouldNotThrow<bool>(() => actual.ShouldBeTrue());
    }
    
    [Fact]
    public void FalseFlag_ShouldBeFalse_NotThrowException()
    {
        const bool actual = false;
        
        ShouldNotThrow<bool>(() => actual.ShouldBeFalse());
    }
    
    [Fact]
    public void FalseFlag_ShouldBeTrue_ThrowsException()
    {
        const bool actual = false;
        
        ShouldThrow(() => actual.ShouldBeTrue(), true, actual);
    }
    
    [Fact]
    public void TrueFlag_ShouldBeFalse_ThrowsException()
    {
        const bool actual = true;
        
        ShouldThrow(() => actual.ShouldBeFalse(), false, actual);
    }
}