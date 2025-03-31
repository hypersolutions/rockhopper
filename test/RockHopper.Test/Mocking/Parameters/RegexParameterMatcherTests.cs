using RockHopper.Assertions;
using RockHopper.Mocking.Parameters;

namespace RockHopper.Test.Mocking.Parameters;

public class RegexParameterMatcherTests 
{
    [Test(InlineArgs = [null])]
    [Test(InlineArgs = [""])]
    [Test(InlineArgs = [" "])]
    [Test(InlineArgs = ["ABC"])]
    [Test(InlineArgs = ["1234567"])]
    [Test(InlineArgs = ["123456789"])]
    public void InvalidPatterMatch_IsMatch_ReturnsFalse(string? text)
    {
        var matcher = new RegexParameterMatcher(() => "^[0-9]{8}$");

        var matches = matcher.IsMatch(text);
        
        matches.ShouldBeFalse();
    }
    
    [Test]
    public void ValidPatterMatch_IsMatch_ReturnsTrue()
    {
        var matcher = new RegexParameterMatcher(() => "^[0-9]{8}$");

        var matches = matcher.IsMatch("12345678");
        
        matches.ShouldBeTrue();
    }
}