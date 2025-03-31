using RockHopper.Assertions;
using RockHopper.Mocking.Parameters;

namespace RockHopper.Test.Mocking.Parameters;

public class ExactParameterMatcherTests 
{
    [Test]
    public void NullMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new ExactParameterMatcher();
        
        var matches = matcher.IsMatch(null);

        matches.ShouldBeTrue();
    }
    
    [Test]
    public void NonNullMatch_IsMatch_ReturnsTrue()
    {
        var value = new object();
        var matcher = new ExactParameterMatcher(value);
        
        var matches = matcher.IsMatch(value);

        matches.ShouldBeTrue();
    }

    [Test]
    public void NonNullMisMatch_IsMatch_ReturnsFalse()
    {
        var matcher = new ExactParameterMatcher(new object());

        var matches = matcher.IsMatch(new object());

        matches.ShouldBeFalse();
    }

    [Test]
    public void IntMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new ExactParameterMatcher(10);

        var matches = matcher.IsMatch(10);

        matches.ShouldBeTrue();
    }

    [Test]
    public void IntMisMatch_IsMatch_ReturnsFalse()
    {
        var matcher = new ExactParameterMatcher(10);

        var matches = matcher.IsMatch(20);

        matches.ShouldBeFalse();
    }

    [Test]
    public void StringMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new ExactParameterMatcher("Homer");

        var matches = matcher.IsMatch("Homer");

        matches.ShouldBeTrue();
    }

    [Test]
    public void StringMisMatch_IsMatch_ReturnsFalse()
    {
        var matcher = new ExactParameterMatcher("Homer");

        var matches = matcher.IsMatch("Marge");

        matches.ShouldBeFalse();
    }
}