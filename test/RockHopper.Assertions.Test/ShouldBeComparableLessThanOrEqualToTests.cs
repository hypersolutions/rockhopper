namespace RockHopper.Assertions.Test;

public class ShouldBeComparableLessThanOrEqualToTests : ShouldBaseTest
{
    [Theory]
    [InlineData((byte)0)]
    [InlineData((byte)1)]
    public void ByteLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(byte delta)
    {
        const byte expected = 10;
        var actual = (byte)(expected - delta);
        
        ShouldNotThrow<byte>(() => actual.ShouldBeLessThanOrEqualTo(expected));
    }
    
    [Fact]
    public void ByteGreaterThan_ShouldBeLessThanOrEqualTo_ThrowsException()
    {
        const byte expected = 10;
        const byte actual = 20;
        
        ShouldThrow(() => actual.ShouldBeLessThanOrEqualTo(expected), expected, actual);
    }
    
    [Theory]
    [InlineData((short)0)]
    [InlineData((short)1)]
    public void ShortLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(short delta)
    {
        const short expected = 10;
        var actual = (short)(expected - delta);
        
        ShouldNotThrow<short>(() => actual.ShouldBeLessThanOrEqualTo(expected));
    }
    
    [Fact]
    public void ShortGreaterThan_ShouldBeLessThanOrEqualTo_ThrowsException()
    {
        const short expected = 10;
        const short actual = 20;
        
        ShouldThrow(() => actual.ShouldBeLessThanOrEqualTo(expected), expected, actual);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void IntLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(int delta)
    {
        const int expected = 10;
        var actual = expected - delta;
        
        ShouldNotThrow<int>(() => actual.ShouldBeLessThanOrEqualTo(expected));
    }
    
    [Fact]
    public void IntGreaterThan_ShouldBeLessThanOrEqualTo_ThrowsException()
    {
        const int expected = 10;
        const int actual = 20;
        
        ShouldThrow(() => actual.ShouldBeLessThanOrEqualTo(expected), expected, actual);
    }
    
    [Theory]
    [InlineData(0u)]
    [InlineData(1u)]
    public void UnsignedIntLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(uint delta)
    {
        const uint expected = 10;
        var actual = expected - delta;
        
        ShouldNotThrow<uint>(() => actual.ShouldBeLessThanOrEqualTo(expected));
    }
    
    [Fact]
    public void UnsignedIntGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const uint expected = 10;
        const uint actual = 20;
        
        ShouldThrow(() => actual.ShouldBeLessThanOrEqualTo(expected), expected, actual);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void LongLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(long delta)
    {
        const long expected = 10;
        var actual = expected - delta;
        
        ShouldNotThrow<long>(() => actual.ShouldBeLessThanOrEqualTo(expected));
    }
    
    [Fact]
    public void LongGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const long expected = 10;
        const long actual = 20;
        
        ShouldThrow(() => actual.ShouldBeLessThanOrEqualTo(expected), expected, actual);
    }
    
    [Theory]
    [InlineData(0ul)]
    [InlineData(1ul)]
    public void UnsignedLongLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(ulong delta)
    {
        const ulong expected = 10;
        var actual = expected - delta;
        
        ShouldNotThrow<ulong>(() => actual.ShouldBeLessThanOrEqualTo(expected));
    }
    
    [Fact]
    public void UnsignedLongGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const ulong expected = 10;
        const ulong actual = 20;
        
        ShouldThrow(() => actual.ShouldBeLessThanOrEqualTo(expected), expected, actual);
    }
    
    [Theory]
    [InlineData(0f)]
    [InlineData(1f)]
    public void FloatLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(float delta)
    {
        const float expected = 10;
        var actual = expected - delta;
        
        ShouldNotThrow<float>(() => actual.ShouldBeLessThanOrEqualTo(expected));
    }
    
    [Fact]
    public void FloatGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const float expected = 10;
        const float actual = 20;
        
        ShouldThrow(() => actual.ShouldBeLessThanOrEqualTo(expected), expected, actual);
    }
    
    [Theory]
    [InlineData(0d)]
    [InlineData(1d)]
    public void DoubleLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(double delta)
    {
        const double expected = 10;
        var actual = expected - delta;
        
        ShouldNotThrow<double>(() => actual.ShouldBeLessThanOrEqualTo(expected));
    }
    
    [Fact]
    public void DoubleGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const double expected = 10;
        const double actual = 20;
        
        ShouldThrow(() => actual.ShouldBeLessThanOrEqualTo(expected), expected, actual);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void DecimalLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(decimal delta)
    {
        const decimal expected = 10;
        var actual = expected - delta;
        
        ShouldNotThrow<decimal>(() => actual.ShouldBeLessThanOrEqualTo(expected));
    }
    
    [Fact]
    public void DecimalGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const decimal expected = 10;
        const decimal actual = 20;
        
        ShouldThrow(() => actual.ShouldBeLessThanOrEqualTo(expected), expected, actual);
    }
}