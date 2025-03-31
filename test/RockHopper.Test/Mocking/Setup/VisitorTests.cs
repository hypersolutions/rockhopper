using RockHopper.Assertions;
using RockHopper.Exceptions;
using RockHopper.Mocking.Setup;
using RockHopper.Mocking.Verifies;

namespace RockHopper.Test.Mocking.Setup;

public class VisitorTests 
{
    private readonly Visitor _visitor = new();
    
    [Test]
    public void NoVisitsExpected_VerifyOccurs_NoExceptionThrown()
    {
        _visitor.AddOccurs(Occurs.Never());

        Should.NotThrow<VerificationException>(() => _visitor.VerifyOccurs());
    }
    
    [Test]
    public void HasVisitButNoneExpected_VerifyOccurs_ThrowsException()
    {
        _visitor.AddOccurs(Occurs.Never());
        _visitor.Increment();

        Should.Throw<VerificationException>(() => _visitor.VerifyOccurs());
    }
    
    [Test]
    public void SingleVisitsExpected_VerifyOccurs_NoExceptionThrown()
    {
        _visitor.AddOccurs(Occurs.Once());
        _visitor.Increment();

        Should.NotThrow<VerificationException>(() => _visitor.VerifyOccurs());
    }
    
    [Test]
    public void HasVisitsButOneExpected_VerifyOccurs_ThrowsException()
    {
        _visitor.AddOccurs(Occurs.Once());
        _visitor.Increment();
        _visitor.Increment();

        Should.Throw<VerificationException>(() => _visitor.VerifyOccurs());
    }
    
    [Test]
    public void HasVisitsButResetBetweenVisits_VerifyOccurs_NoExceptionThrown()
    {
        _visitor.AddOccurs(Occurs.Once());
        _visitor.Increment();
        _visitor.Reset();
        _visitor.Increment();

        Should.NotThrow<VerificationException>(() => _visitor.VerifyOccurs());
    }
}