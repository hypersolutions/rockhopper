namespace RockHopper.Assertions.Test;

public class ShouldBeEnumerableTests : ShouldBaseTest
{
    [Fact]
    public void NonEmptyArray_ShouldBeEmpty_ThrowsException()
    {
        int[] expected = [1, 2];
        
        ShouldThrow(() => expected.ShouldBeEmpty(), 0, 2);
    }
    
    [Fact]
    public void EmptyArray_ShouldBeEmpty_NotThrowException()
    {
        int[] expected = [];
        
        ShouldNotThrow<int>(() => expected.ShouldBeEmpty());
    }
    
    [Fact]
    public void EmptyArray_ShouldBeSingle_ThrowsException()
    {
        int[] expected = [];
        
        ShouldThrow(() => expected.ShouldBeSingle(), 1, 0);
    }
    
    [Fact]
    public void ArrayWithMoreThanOne_ShouldBeSingle_ThrowsException()
    {
        int[] expected = [1, 2];
        
        ShouldThrow(() => expected.ShouldBeSingle(), 1, 0);
    }
    
    [Fact]
    public void ArrayWithOne_ShouldBeSingle_NotThrowException()
    {
        int[] expected = [1];
        
        ShouldNotThrow<int>(() => expected.ShouldBeSingle());
    }
    
    [Fact]
    public void ArrayWithMoreItemsThanExpected_ShouldContainCount_ThrowsException()
    {
        int[] expected = [1, 2];
        
        ShouldThrow(() => expected.ShouldContainCount(1), 1, 2);
    }
    
    [Fact]
    public void ArrayWithItems_ShouldContainCount_NotThrowException()
    {
        int[] expected = [1, 2];
        
        ShouldNotThrow<int>(() => expected.ShouldContainCount(2));
    }
}