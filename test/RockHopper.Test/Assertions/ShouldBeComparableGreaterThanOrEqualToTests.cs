using RockHopper.Assertions;
using RockHopper.Assertions.Exceptions;

namespace RockHopper.Test.Assertions;

public class ShouldBeComparableGreaterThanOrEqualToTests
{
    [Test(InlineArgs = [(byte)0])]
    [Test(InlineArgs = [(byte)1])]
    public void ByteGreaterThanOrEqualTo_ShouldBeGreaterThanOrEqualTo_NotThrowException(byte delta)
    {
        const byte expected = 10;
        var actual = (byte)(expected + delta);
        
        actual.ShouldBeGreaterThanOrEqualTo(expected);
    }
    
    [Test]
    public void ByteLessThan_ShouldBeGreaterThanOrEqualTo_ThrowsException()
    {
        const byte expected = 20;
        const byte actual = 10;
        
        try
        {
            actual.ShouldBeGreaterThanOrEqualTo(expected);
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
    public void ShortGreaterThanOrEqualTo_ShouldBeGreaterThanOrEqualTo_NotThrowException(short delta)
    {
        const short expected = 10;
        var actual = (short)(expected + delta);
        
        actual.ShouldBeGreaterThanOrEqualTo(expected);
    }
    
    [Test]
    public void ShortLessThan_ShouldBeGreaterThanOrEqualTo_ThrowsException()
    {
        const short expected = 20;
        const short actual = 10;
        
        try
        {
            actual.ShouldBeGreaterThanOrEqualTo(expected);
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
    public void IntGreaterThanOrEqualTo_ShouldBeGreaterThanOrEqualTo_NotThrowException(int delta)
    {
        const int expected = 10;
        var actual = expected + delta;
        
        actual.ShouldBeGreaterThanOrEqualTo(expected);
    }
    
    [Test]
    public void IntLessThan_ShouldBeGreaterThanOrEqualTo_ThrowsException()
    {
        const int expected = 20;
        const int actual = 10;
        
        try
        {
            actual.ShouldBeGreaterThanOrEqualTo(expected);
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
    public void UnsignedIntGreaterThanOrEqualTo_ShouldBeGreaterThanOrEqualTo_NotThrowException(uint delta)
    {
        const uint expected = 10;
        var actual = expected + delta;
        
        actual.ShouldBeGreaterThanOrEqualTo(expected);
    }
    
    [Test]
    public void UnsignedIntLessThan_ShouldBeGreaterThan_ThrowsException()
    {
        const uint expected = 20;
        const uint actual = 10;
        
        try
        {
            actual.ShouldBeGreaterThanOrEqualTo(expected);
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
    public void LongGreaterThanOrEqualTo_ShouldBeGreaterThanOrEqualTo_NotThrowException(long delta)
    {
        const long expected = 10;
        var actual = expected + delta;
        
        actual.ShouldBeGreaterThanOrEqualTo(expected);
    }
    
    [Test]
    public void LongLessThan_ShouldBeGreaterThan_ThrowsException()
    {
        const long expected = 20;
        const long actual = 10;
        
        try
        {
            actual.ShouldBeGreaterThanOrEqualTo(expected);
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
    public void UnsignedLongGreaterThanOrEqualTo_ShouldBeGreaterThanOrEqualTo_NotThrowException(ulong delta)
    {
        const ulong expected = 10;
        var actual = expected + delta;
        
        actual.ShouldBeGreaterThanOrEqualTo(expected);
    }
    
    [Test]
    public void UnsignedLongLessThan_ShouldBeGreaterThan_ThrowsException()
    {
        const ulong expected = 20;
        const ulong actual = 10;
        
        try
        {
            actual.ShouldBeGreaterThanOrEqualTo(expected);
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
    public void FloatGreaterThanOrEqualTo_ShouldBeGreaterThanOrEqualTo_NotThrowException(float delta)
    {
        const float expected = 10;
        var actual = expected + delta;
        
        actual.ShouldBeGreaterThanOrEqualTo(expected);
    }
    
    [Test]
    public void FloatLessThan_ShouldBeGreaterThan_ThrowsException()
    {
        const float expected = 20;
        const float actual = 10;
        
        try
        {
            actual.ShouldBeGreaterThanOrEqualTo(expected);
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
    public void DoubleGreaterThanOrEqualTo_ShouldBeGreaterThanOrEqualTo_NotThrowException(double delta)
    {
        const double expected = 10;
        var actual = expected + delta;
        
        actual.ShouldBeGreaterThanOrEqualTo(expected);
    }
    
    [Test]
    public void DoubleLessThan_ShouldBeGreaterThan_ThrowsException()
    {
        const double expected = 20;
        const double actual = 10;
        
        try
        {
            actual.ShouldBeGreaterThanOrEqualTo(expected);
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
    public void DecimalGreaterThanOrEqualTo_ShouldBeGreaterThanOrEqualTo_NotThrowException(decimal delta)
    {
        const decimal expected = 10;
        var actual = expected + delta;
        
        actual.ShouldBeGreaterThanOrEqualTo(expected);
    }
    
    [Test]
    public void DecimalLessThan_ShouldBeGreaterThan_ThrowsException()
    {
        const decimal expected = 20;
        const decimal actual = 10;
        
        try
        {
            actual.ShouldBeGreaterThanOrEqualTo(expected);
        }
        catch (Exception error) when (error is ExpectedAndActualException<decimal>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<decimal>(expected, actual, "Failed to throw expected exception.");
    }
}