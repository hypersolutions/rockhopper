namespace RockHopper.Assertions.Test;

public class ShouldBeComparableLessThanTests : ShouldBaseTest
{
    [Fact]
    public void ByteLessThan_ShouldBeLessThan_NotThrowException()
    {
        const byte expected = 20;
        const byte actual = 10;
        
        ShouldNotThrow<byte>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Theory]
    [InlineData((byte)0)]
    [InlineData((byte)1)]
    public void ByteLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(byte delta)
    {
        const byte expected = 10;
        var actual = (byte)(expected + delta);
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Fact]
    public void ShortLessThan_ShouldBeLessThan_NotThrowException()
    {
        const short expected = 20;
        const short actual = 10;
        
        ShouldNotThrow<short>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Theory]
    [InlineData((short)0)]
    [InlineData((short)1)]
    public void ShortLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(short delta)
    {
        const short expected = 10;
        var actual = (short)(expected + delta);
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Fact]
    public void IntLessThan_ShouldBeLessThan_NotThrowException()
    {
        const int expected = 20;
        const int actual = 10;
        
        ShouldNotThrow<int>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void IntLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(int delta)
    {
        const int expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Fact]
    public void UnsignedIntLessThan_ShouldBeLessThan_NotThrowException()
    {
        const uint expected = 20;
        const uint actual = 10;
        
        ShouldNotThrow<uint>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Theory]
    [InlineData(0u)]
    [InlineData(1u)]
    public void UnsignedIntLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(uint delta)
    {
        const uint expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Fact]
    public void LongLessThan_ShouldBeLessThan_NotThrowException()
    {
        const long expected = 20;
        const long actual = 10;
        
        ShouldNotThrow<long>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void LongLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(long delta)
    {
        const long expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Fact]
    public void UnsignedLongLessThan_ShouldBeLessThan_NotThrowException()
    {
        const ulong expected = 20;
        const ulong actual = 10;
        
        ShouldNotThrow<ulong>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Theory]
    [InlineData(0ul)]
    [InlineData(1ul)]
    public void UnsignedLongLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(ulong delta)
    {
        const ulong expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Fact]
    public void FloatLessThan_ShouldBeLessThan_NotThrowException()
    {
        const float expected = 20;
        const float actual = 10;
        
        ShouldNotThrow<float>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Theory]
    [InlineData(0f)]
    [InlineData(1f)]
    public void FloatLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(float delta)
    {
        const float expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Fact]
    public void DoubleLessThan_ShouldBeLessThan_NotThrowException()
    {
        const double expected = 20;
        const double actual = 10;
        
        ShouldNotThrow<double>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Theory]
    [InlineData(0d)]
    [InlineData(1d)]
    public void DoubleLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(double delta)
    {
        const double expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
    
    [Fact]
    public void DecimalLessThan_ShouldBeLessThan_NotThrowException()
    {
        const decimal expected = 20;
        const decimal actual = 10;
        
        ShouldNotThrow<decimal>(() => actual.ShouldBeLessThan(expected));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void DecimalLessThanOrEqualTo_ShouldBeLessThan_ThrowsException(decimal delta)
    {
        const decimal expected = 10;
        var actual = expected + delta;
        
        ShouldThrow(() => actual.ShouldBeLessThan(expected), expected, actual);
    }
}