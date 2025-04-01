using RockHopper.Assertions;

namespace RockHopper.Test.Assertions;

public class ShouldBeComparableLessThanTests : ShouldBaseTest
{
    [Test]
    public void ByteLessThan_ShouldBeLessThan_NotThrowException()
    {
        const byte expected = 20;
        const byte actual = 10;
        
        ShouldNotThrow<byte>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Test(InlineArgs = [(byte)0])]
    [Test(InlineArgs = [(byte)1])]
    public void ByteLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(byte delta)
    {
        const byte expected = 10;
        var actual = (byte)(expected + delta);
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Test]
    public void ShortLessThan_ShouldBeLessThan_NotThrowException()
    {
        const short expected = 20;
        const short actual = 10;
        
        ShouldNotThrow<short>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Test(InlineArgs = [(short)0])]
    [Test(InlineArgs = [(short)1])]
    public void ShortLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(short delta)
    {
        const short expected = 10;
        var actual = (short)(expected + delta);
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Test]
    public void IntLessThan_ShouldBeLessThan_NotThrowException()
    {
        const int expected = 20;
        const int actual = 10;
        
        ShouldNotThrow<int>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void IntLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(int delta)
    {
        const int expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Test]
    public void UnsignedIntLessThan_ShouldBeLessThan_NotThrowException()
    {
        const uint expected = 20;
        const uint actual = 10;
        
        ShouldNotThrow<uint>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Test(InlineArgs = [0u])]
    [Test(InlineArgs = [1u])]
    public void UnsignedIntLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(uint delta)
    {
        const uint expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Test]
    public void LongLessThan_ShouldBeLessThan_NotThrowException()
    {
        const long expected = 20;
        const long actual = 10;
        
        ShouldNotThrow<long>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void LongLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(long delta)
    {
        const long expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Test]
    public void UnsignedLongLessThan_ShouldBeLessThan_NotThrowException()
    {
        const ulong expected = 20;
        const ulong actual = 10;
        
        ShouldNotThrow<ulong>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Test(InlineArgs = [0ul])]
    [Test(InlineArgs = [1ul])]
    public void UnsignedLongLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(ulong delta)
    {
        const ulong expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Test]
    public void FloatLessThan_ShouldBeLessThan_NotThrowException()
    {
        const float expected = 20;
        const float actual = 10;
        
        ShouldNotThrow<float>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Test(InlineArgs = [0f])]
    [Test(InlineArgs = [1f])]
    public void FloatLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(float delta)
    {
        const float expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Test]
    public void DoubleLessThan_ShouldBeLessThan_NotThrowException()
    {
        const double expected = 20;
        const double actual = 10;
        
        ShouldNotThrow<double>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Test(InlineArgs = [0d])]
    [Test(InlineArgs = [1d])]
    public void DoubleLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(double delta)
    {
        const double expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Test]
    public void DecimalLessThan_ShouldBeLessThan_NotThrowException()
    {
        const decimal expected = 20;
        const decimal actual = 10;
        
        ShouldNotThrow<decimal>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void DecimalLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(decimal delta)
    {
        const decimal expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
}