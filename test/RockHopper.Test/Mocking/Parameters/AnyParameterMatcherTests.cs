using RockHopper.Assertions;
using RockHopper.Mocking.Parameters;

namespace RockHopper.Test.Mocking.Parameters;

public class AnyParameterMatcherTests 
{
    [Test]
    public void NullMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new AnyParameterMatcher();
        
        var matches = matcher.IsMatch(null);

        matches.ShouldBeTrue();
    }

    [Test]
    public void NonNullMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new AnyParameterMatcher();
        
        var matches = matcher.IsMatch(new object());

        matches.ShouldBeTrue();
    }

    [Test]
    public void IntMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new AnyParameterMatcher();
        
        var matches = matcher.IsMatch(10);

        matches.ShouldBeTrue();
    }

    [Test]
    public void StringMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new AnyParameterMatcher();
        
        var matches = matcher.IsMatch("Homer");

        matches.ShouldBeTrue();
    }
}