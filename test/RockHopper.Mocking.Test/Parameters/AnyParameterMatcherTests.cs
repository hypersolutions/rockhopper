using RockHopper.Assertions;
using RockHopper.Mocking.Parameters;

namespace RockHopper.Mocking.Test.Parameters;

public class AnyParameterMatcherTests 
{
    [Fact]
    public void NullMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new AnyParameterMatcher();
        
        var matches = matcher.IsMatch(null);

        matches.ShouldBeTrue();
    }

    [Fact]
    public void NonNullMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new AnyParameterMatcher();
        
        var matches = matcher.IsMatch(new object());

        matches.ShouldBeTrue();
    }

    [Fact]
    public void IntMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new AnyParameterMatcher();
        
        var matches = matcher.IsMatch(10);

        matches.ShouldBeTrue();
    }

    [Fact]
    public void StringMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new AnyParameterMatcher();
        
        var matches = matcher.IsMatch("Homer");

        matches.ShouldBeTrue();
    }
}