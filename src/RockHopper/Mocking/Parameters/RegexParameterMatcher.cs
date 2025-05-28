using System.Text.RegularExpressions;

namespace RockHopper.Mocking.Parameters;

internal class RegexParameterMatcher : ParameterMatcher
{
    private string _pattern = string.Empty;
    
    public override bool IsMatch(object? actual)
    {
        return actual is not null && Regex.IsMatch(actual.ToString()!, _pattern);
    }
    
    public override void SetValue(Delegate? predicate)
    {
        _pattern = predicate?.DynamicInvoke() as string ?? string.Empty;
    }
}