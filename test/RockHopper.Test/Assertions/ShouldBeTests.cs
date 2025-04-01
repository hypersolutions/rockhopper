using RockHopper.Assertions;

namespace RockHopper.Test.Assertions;

public class ShouldBeTests : ShouldBaseTest
{
    [Test]
    public void IntValue_ShouldBe_NotThrowException()
    {
        const int expected = 10;
        const int actual = 10;
        
        ShouldNotThrow<int>(() => actual.ShouldBe(expected));
    }
    
    [Test]
    public void IntValue_ShouldBe_ThrowsException()
    {
        const int expected = 10;
        const int actual = 20;

        ShouldThrow(() => actual.ShouldBe(expected), expected, actual);
    }
}