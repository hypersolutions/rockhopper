using RockHopper.Assertions;
using RockHopper.Mocking.Parameters;

namespace RockHopper.Test.Mocking.Parameters;

public class ExactParameterMatcherTests 
{
    [Fact]
    public void NullMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new ExactParameterMatcher();
        
        var matches = matcher.IsMatch(null);

        matches.ShouldBeTrue();
    }
    
    [Fact]
    public void NonNullMatch_IsMatch_ReturnsTrue()
    {
        var value = new object();
        var matcher = new ExactParameterMatcher();
        matcher.SetValue(() => value);
        
        var matches = matcher.IsMatch(value);

        matches.ShouldBeTrue();
    }

    [Fact]
    public void NonNullMisMatch_IsMatch_ReturnsFalse()
    {
        var matcher = new ExactParameterMatcher();
        matcher.SetValue(() => new object());

        var matches = matcher.IsMatch(new object());

        matches.ShouldBeFalse();
    }

    [Fact]
    public void IntMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new ExactParameterMatcher();
        matcher.SetValue(() => 10);

        var matches = matcher.IsMatch(10);

        matches.ShouldBeTrue();
    }

    [Fact]
    public void IntMisMatch_IsMatch_ReturnsFalse()
    {
        var matcher = new ExactParameterMatcher();
        matcher.SetValue(() => 10);

        var matches = matcher.IsMatch(20);

        matches.ShouldBeFalse();
    }

    [Fact]
    public void StringMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new ExactParameterMatcher();
        matcher.SetValue(() => "Homer");

        var matches = matcher.IsMatch("Homer");

        matches.ShouldBeTrue();
    }

    [Fact]
    public void StringMisMatch_IsMatch_ReturnsFalse()
    {
        var matcher = new ExactParameterMatcher();
        matcher.SetValue(() => "Homer");
        
        var matches = matcher.IsMatch("Marge");

        matches.ShouldBeFalse();
    }
}