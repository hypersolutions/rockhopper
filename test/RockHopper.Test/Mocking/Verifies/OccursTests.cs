using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;
using RockHopper.Mocking.Verifies;

namespace RockHopper.Test.Mocking.Verifies;

public class OccursTests
{
    [Fact]
    public void ZeroNeverOccurs_Assert_DoesNotThrowException()
    {
        var occurred = Occurs.Never();
        
        Should.NotThrow<VerificationException>(() => occurred.Assert(0));
    }
    
    [Fact]
    public void NonZeroNeverOccurs_Assert_ThrowsException()
    {
        var occurred = Occurs.Never();
        
        Should.Throw<VerificationException>(() => occurred.Assert(1));
    }
    
    [Fact]
    public void SingleOnceOccurs_Assert_DoesNotThrowException()
    {
        var occurred = Occurs.Once();

        Should.NotThrow<VerificationException>(() => occurred.Assert(1));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(2)]
    public void NonSingleOnceOccurs_Assert_ThrowsException(int count)
    {
        var occurred = Occurs.Once();
        
        Should.Throw<VerificationException>(() => occurred.Assert(count));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void ExactlyOccurs_Assert_DoesNotThrowException(int count)
    {
        var occurred = Occurs.Exactly(count);
        
        Should.NotThrow<VerificationException>(() => occurred.Assert(count));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void ExactlyMismatchOccurs_Assert_ThrowsException(int count)
    {
        var occurred = Occurs.Exactly(count);
        
        Should.Throw<VerificationException>(() => occurred.Assert(count + 1));
    }
    
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    public void AtLeastOccurs_Assert_DoesNotThrowException(int count)
    {
        var occurred = Occurs.AtLeast(2);
        
        Should.NotThrow<VerificationException>(() => occurred.Assert(count));
    }
    
    [Fact]
    public void BelowAtLeastOccurs_Assert_ThrowsException()
    {
        var occurred = Occurs.AtLeast(2);
        
        Should.Throw<VerificationException>(() => occurred.Assert(1));
    }
}