using RockHopper.Assertions;
using RockHopper.Exceptions;
using RockHopper.Mocking.Verifies;

namespace RockHopper.Test.Mocking.Verifies;

public class OccursTests
{
    [Test]
    public void ZeroNeverOccurs_Assert_DoesNotThrowException()
    {
        var occurred = Occurs.Never();
        
        Should.NotThrow<VerificationException>(() => occurred.Assert(0));
    }
    
    [Test]
    public void NonZeroNeverOccurs_Assert_ThrowsException()
    {
        var occurred = Occurs.Never();
        
        Should.Throw<VerificationException>(() => occurred.Assert(1));
    }
    
    [Test]
    public void SingleOnceOccurs_Assert_DoesNotThrowException()
    {
        var occurred = Occurs.Once();

        Should.NotThrow<VerificationException>(() => occurred.Assert(1));
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [2])]
    public void NonSingleOnceOccurs_Assert_ThrowsException(int count)
    {
        var occurred = Occurs.Once();
        
        Should.Throw<VerificationException>(() => occurred.Assert(count));
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void ExactlyOccurs_Assert_DoesNotThrowException(int count)
    {
        var occurred = Occurs.Exactly(count);
        
        Should.NotThrow<VerificationException>(() => occurred.Assert(count));
    }
    
    [Test(InlineArgs = [0])]
    [Test(InlineArgs = [1])]
    public void ExactlyMismatchOccurs_Assert_ThrowsException(int count)
    {
        var occurred = Occurs.Exactly(count);
        
        Should.Throw<VerificationException>(() => occurred.Assert(count + 1));
    }
    
    [Test(InlineArgs = [2])]
    [Test(InlineArgs = [3])]
    public void AtLeastOccurs_Assert_DoesNotThrowException(int count)
    {
        var occurred = Occurs.AtLeast(2);
        
        Should.NotThrow<VerificationException>(() => occurred.Assert(count));
    }
    
    [Test]
    public void BelowAtLeastOccurs_Assert_ThrowsException()
    {
        var occurred = Occurs.AtLeast(2);
        
        Should.Throw<VerificationException>(() => occurred.Assert(1));
    }
}