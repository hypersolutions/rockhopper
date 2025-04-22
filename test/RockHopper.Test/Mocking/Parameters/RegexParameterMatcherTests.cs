using RockHopper.Assertions;
using RockHopper.Mocking.Parameters;

namespace RockHopper.Test.Mocking.Parameters;

public class RegexParameterMatcherTests 
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("ABC")]
    [InlineData("1234567")]
    [InlineData("123456789")]
    public void InvalidPatterMatch_IsMatch_ReturnsFalse(string? text)
    {
        var matcher = new RegexParameterMatcher(() => "^[0-9]{8}$");

        var matches = matcher.IsMatch(text);
        
        matches.ShouldBeFalse();
    }
    
    [Fact]
    public void ValidPatterMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new RegexParameterMatcher(() => "^[0-9]{8}$");

        var matches = matcher.IsMatch("12345678");
        
        matches.ShouldBeTrue();
    }
}