using RockHopper.Assertions;
using RockHopper.Assertions.Exceptions;

namespace RockHopper.Test.Assertions;

public class ShouldBeComparableGreaterThanTests
{
    [Test]
    public void ByteGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const byte expected = 10;
        const byte actual = 20;
        
        actual.ShouldBeGreaterThan(expected);
    }
    
    [Test(InlineArgs = [(byte)0])]
    [Test(InlineArgs = [(byte)1])]
    public void ByteLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(byte delta)
    {
        const byte expected = 10;
        var actual = (byte)(expected - delta);
        
        try
        {
            actual.ShouldBeGreaterThan(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<byte>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<byte>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test]
    public void ShortGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const short expected = 10;
        const short actual = 20;
        
        actual.ShouldBeGreaterThan(expected);
    }
    
    [Test(InlineArgs = [(short)0])]
    [Test(InlineArgs = [(short)1])]
    public void ShortLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(short delta)
    {
        const short expected = 10;
        var actual = (short)(expected - delta);
        
        try
        {
            actual.ShouldBeGreaterThan(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<short>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<short>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test]
    public void IntGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const int expected = 10;
        const int actual = 20;
        
        actual.ShouldBeGreaterThan(expected);
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void IntLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(int delta)
    {
        const int expected = 10;
        var actual = expected - delta;
        
        try
        {
            actual.ShouldBeGreaterThan(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<int>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<int>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test]
    public void UnsignedIntGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const uint expected = 10;
        const uint actual = 20;
        
        actual.ShouldBeGreaterThan(expected);
    }
    
    [Test(InlineArgs = [0u])]
    [Test(InlineArgs = [1u])]
    public void UnsignedIntLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(uint delta)
    {
        const uint expected = 10;
        var actual = expected - delta;
        
        try
        {
            actual.ShouldBeGreaterThan(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<uint>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<uint>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test]
    public void LongGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const long expected = 10;
        const long actual = 20;
        
        actual.ShouldBeGreaterThan(expected);
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void LongLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(long delta)
    {
        const long expected = 10;
        var actual = expected - delta;
        
        try
        {
            actual.ShouldBeGreaterThan(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<long>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<long>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test]
    public void UnsignedLongGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const ulong expected = 10;
        const ulong actual = 20;
        
        actual.ShouldBeGreaterThan(expected);
    }
    
    [Test(InlineArgs = [0ul])]
    [Test(InlineArgs = [1ul])]
    public void UnsignedLongLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(ulong delta)
    {
        const ulong expected = 10;
        var actual = expected - delta;
        
        try
        {
            actual.ShouldBeGreaterThan(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<ulong>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<ulong>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test]
    public void FloatGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const float expected = 10;
        const float actual = 20;
        
        actual.ShouldBeGreaterThan(expected);
    }
    
    [Test(InlineArgs = [0f])]
    [Test(InlineArgs = [1f])]
    public void FloatLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(float delta)
    {
        const float expected = 10;
        var actual = expected - delta;
        
        try
        {
            actual.ShouldBeGreaterThan(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<float>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<float>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test]
    public void DoubleGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const double expected = 10;
        const double actual = 20;
        
        actual.ShouldBeGreaterThan(expected);
    }
    
    [Test(InlineArgs = [0d])]
    [Test(InlineArgs = [1d])]
    public void DoubleLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(double delta)
    {
        const double expected = 10;
        var actual = expected - delta;
        
        try
        {
            actual.ShouldBeGreaterThan(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<double>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<double>(expected, actual, "Failed to throw expected exception.");
    }
    
    [Test]
    public void DecimalGreaterThan_ShouldBeGreaterThan_NotThrowException()
    {
        const decimal expected = 10;
        const decimal actual = 20;
        
        actual.ShouldBeGreaterThan(expected);
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void DecimalLessThanOrEqualTo_ShouldBeGreaterThan_ThrowsException(decimal delta)
    {
        const decimal expected = 10;
        var actual = expected - delta;
        
        try
        {
            actual.ShouldBeGreaterThan(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<decimal>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<decimal>(expected, actual, "Failed to throw expected exception.");
    }
}