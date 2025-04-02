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
    
    [Test]
    public void ArrayWithMoreItemsThanExpected_ShouldContainCount_ThrowsException()
    {
        int[] expected = [1, 2];
        
        ShouldThrow(() => expected.ShouldContainCount(1), 1, 2);
    }
    
    [Test]
    public void ArrayWithItems_ShouldContainCount_NotThrowException()
    {
        int[] expected = [1, 2];
        
        ShouldNotThrow<int>(() => expected.ShouldContainCount(2));
    }
}