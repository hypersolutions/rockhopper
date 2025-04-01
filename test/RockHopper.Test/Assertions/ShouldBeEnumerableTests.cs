using RockHopper.Assertions;

namespace RockHopper.Test.Assertions;

public class ShouldBeEnumerableTests : ShouldBaseTest
{
    [Test]
    public void EmptyArray_ShouldBeSingle_ThrowsException()
    {
        int[] expected = [];
        
        ShouldThrow(() => expected.ShouldBeSingle(), 1, 0);
    }
    
    [Test]
    public void ArrayWithMoreThanOne_ShouldBeSingle_ThrowsException()
    {
        int[] expected = [1, 2];
        
        ShouldThrow(() => expected.ShouldBeSingle(), 1, 0);
    }
    
    [Test]
    public void ArrayWithOne_ShouldBeSingle_NotThrowException()
    {
        int[] expected = [1];
        
        ShouldNotThrow<int>(() => expected.ShouldBeSingle());
    }
}