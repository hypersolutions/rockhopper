using RockHopper.Assertions;
using RockHopper.Assertions.Exceptions;

namespace RockHopper.Test.Assertions;

public class ShouldBeComparableLessThanOrEqualToTests
{
    [Test(InlineArgs = [(byte)0])]
    [Test(InlineArgs = [(byte)1])]
    public void ByteLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(byte delta)
    {
        const byte expected = 10;
        var actual = (byte)(expected - delta);
        
        actual.ShouldBeLessThanOrEqualTo(expected);
    }
    
    [Test]
    public void ByteGreaterThan_ShouldBeLessThanOrEqualTo_ThrowsException()
    {
        const byte expected = 10;
        const byte actual = 20;
        
        try
        {
            actual.ShouldBeLessThanOrEqualTo(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<byte>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<byte>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test(InlineArgs = [(short)0])]
    [Test(InlineArgs = [(short)1])]
    public void ShortLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(short delta)
    {
        const short expected = 10;
        var actual = (short)(expected - delta);
        
        actual.ShouldBeLessThanOrEqualTo(expected);
    }
    
    [Test]
    public void ShortGreaterThan_ShouldBeLessThanOrEqualTo_ThrowsException()
    {
        const short expected = 10;
        const short actual = 20;
        
        try
        {
            actual.ShouldBeLessThanOrEqualTo(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<short>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<short>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void IntLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(int delta)
    {
        const int expected = 10;
        var actual = expected - delta;
        
        actual.ShouldBeLessThanOrEqualTo(expected);
    }
    
    [Test]
    public void IntGreaterThan_ShouldBeLessThanOrEqualTo_ThrowsException()
    {
        const int expected = 10;
        const int actual = 20;
        
        try
        {
            actual.ShouldBeLessThanOrEqualTo(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<int>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<int>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test(InlineArgs = [0u])]
    [Test(InlineArgs = [1u])]
    public void UnsignedIntLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(uint delta)
    {
        const uint expected = 10;
        var actual = expected - delta;
        
        actual.ShouldBeLessThanOrEqualTo(expected);
    }
    
    [Test]
    public void UnsignedIntGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const uint expected = 10;
        const uint actual = 20;
        
        try
        {
            actual.ShouldBeLessThanOrEqualTo(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<uint>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<uint>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void LongLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(long delta)
    {
        const long expected = 10;
        var actual = expected - delta;
        
        actual.ShouldBeLessThanOrEqualTo(expected);
    }
    
    [Test]
    public void LongGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const long expected = 10;
        const long actual = 20;
        
        try
        {
            actual.ShouldBeLessThanOrEqualTo(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<long>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<long>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test(InlineArgs = [0ul])]
    [Test(InlineArgs = [1ul])]
    public void UnsignedLongLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(ulong delta)
    {
        const ulong expected = 10;
        var actual = expected - delta;
        
        actual.ShouldBeLessThanOrEqualTo(expected);
    }
    
    [Test]
    public void UnsignedLongGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const ulong expected = 10;
        const ulong actual = 20;
        
        try
        {
            actual.ShouldBeLessThanOrEqualTo(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<ulong>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<ulong>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test(InlineArgs = [0f])]
    [Test(InlineArgs = [1f])]
    public void FloatLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(float delta)
    {
        const float expected = 10;
        var actual = expected - delta;
        
        actual.ShouldBeLessThanOrEqualTo(expected);
    }
    
    [Test]
    public void FloatGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const float expected = 10;
        const float actual = 20;
        
        try
        {
            actual.ShouldBeLessThanOrEqualTo(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<float>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<float>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test(InlineArgs = [0d])]
    [Test(InlineArgs = [1d])]
    public void DoubleLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(double delta)
    {
        const double expected = 10;
        var actual = expected - delta;
        
        actual.ShouldBeLessThanOrEqualTo(expected);
    }
    
    [Test]
    public void DoubleGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const double expected = 10;
        const double actual = 20;
        
        try
        {
            actual.ShouldBeLessThanOrEqualTo(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<double>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<double>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void DecimalLessThanOrEqualTo_ShouldBeLessThanOrEqualTo_NotThrowException(decimal delta)
    {
        const decimal expected = 10;
        var actual = expected - delta;
        
        actual.ShouldBeLessThanOrEqualTo(expected);
    }
    
    [Test]
    public void DecimalGreaterThan_ShouldBeLessThan_ThrowsException()
    {
        const decimal expected = 10;
        const decimal actual = 20;
        
        try
        {
            actual.ShouldBeLessThanOrEqualTo(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<decimal>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<decimal>(expected, actual, "Failed to throw expected exception.");
    }
}