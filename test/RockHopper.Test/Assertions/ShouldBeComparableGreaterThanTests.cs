using RockHopper.Assertions;

namespace RockHopper.Test.Assertions;

public class ShouldBeComparableGreaterThanTests : ShouldBaseTest
{
    [Test]
    public void ByteGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const byte expected = 10;
        const byte actual = 20;
        
        ShouldNotThrow<byte>(() => actual.ShouldBeGreaterThan(expected));
    }
    
    [Test(InlineArgs = [(byte)0])]
    [Test(InlineArgs = [(byte)1])]
    public void ByteLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(byte delta)
    {
        const byte expected = 10;
        var actual = (byte)(expected - delta);
        
        ShouldThrow(() => actual.ShouldBeGreaterThan(expected), expected, actual);
    }
    
    [Test]
    public void ShortGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const short expected = 10;
        const short actual = 20;
        
        ShouldNotThrow<short>(() => actual.ShouldBeGreaterThan(expected));
    }
    
    [Test(InlineArgs = [(short)0])]
    [Test(InlineArgs = [(short)1])]
    public void ShortLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(short delta)
    {
        const short expected = 10;
        var actual = (short)(expected - delta);
        
        ShouldThrow(() => actual.ShouldBeGreaterThan(expected), expected, actual);
    }
    
    [Test]
    public void IntGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const int expected = 10;
        const int actual = 20;
        
        ShouldNotThrow<int>(() => actual.ShouldBeGreaterThan(expected));
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void IntLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(int delta)
    {
        const int expected = 10;
        var actual = expected - delta;
        
        ShouldThrow(() => actual.ShouldBeGreaterThan(expected), expected, actual);
    }
    
    [Test]
    public void UnsignedIntGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const uint expected = 10;
        const uint actual = 20;
        
        ShouldNotThrow<uint>(() => actual.ShouldBeGreaterThan(expected));
    }
    
    [Test(InlineArgs = [0u])]
    [Test(InlineArgs = [1u])]
    public void UnsignedIntLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(uint delta)
    {
        const uint expected = 10;
        var actual = expected - delta;
        
        ShouldThrow(() => actual.ShouldBeGreaterThan(expected), expected, actual);
    }
    
    [Test]
    public void LongGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const long expected = 10;
        const long actual = 20;
        
        ShouldNotThrow<long>(() => actual.ShouldBeGreaterThan(expected));
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void LongLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(long delta)
    {
        const long expected = 10;
        var actual = expected - delta;
        
        ShouldThrow(() => actual.ShouldBeGreaterThan(expected), expected, actual);
    }
    
    [Test]
    public void UnsignedLongGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const ulong expected = 10;
        const ulong actual = 20;
        
        ShouldNotThrow<ulong>(() => actual.ShouldBeGreaterThan(expected));
    }
    
    [Test(InlineArgs = [0ul])]
    [Test(InlineArgs = [1ul])]
    public void UnsignedLongLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(ulong delta)
    {
        const ulong expected = 10;
        var actual = expected - delta;
        
        ShouldThrow(() => actual.ShouldBeGreaterThan(expected), expected, actual);
    }
    
    [Test]
    public void FloatGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const float expected = 10;
        const float actual = 20;
        
        ShouldNotThrow<float>(() => actual.ShouldBeGreaterThan(expected));
    }
    
    [Test(InlineArgs = [0f])]
    [Test(InlineArgs = [1f])]
    public void FloatLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(float delta)
    {
        const float expected = 10;
        var actual = expected - delta;
        
        ShouldThrow(() => actual.ShouldBeGreaterThan(expected), expected, actual);
    }
    
    [Test]
    public void DoubleGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const double expected = 10;
        const double actual = 20;
        
        ShouldNotThrow<double>(() => actual.ShouldBeGreaterThan(expected));
    }
    
    [Test(InlineArgs = [0d])]
    [Test(InlineArgs = [1d])]
    public void DoubleLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(double delta)
    {
        const double expected = 10;
        var actual = expected - delta;
        
        ShouldThrow(() => actual.ShouldBeGreaterThan(expected), expected, actual);
    }
    
    [Test]
    public void DecimalGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const decimal expected = 10;
        const decimal actual = 20;
        
        ShouldNotThrow<decimal>(() => actual.ShouldBeGreaterThan(expected));
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void DecimalLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(decimal delta)
    {
        const decimal expected = 10;
        var actual = expected - delta;
        
        ShouldThrow(() => actual.ShouldBeGreaterThan(expected), expected, actual);
    }
}