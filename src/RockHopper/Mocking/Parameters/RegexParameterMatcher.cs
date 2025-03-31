using System.Text.RegularExpressions;

namespace RockHopper.Mocking.Parameters;

internal class RegexParameterMatcher : ParameterMatcher
{
    private readonly string _pattern;

    internal RegexParameterMatcher(Delegate predicate)
    {
        _pattern = predicate.DynamicInvoke() as string ?? string.Empty;
    }
    
    public override bool IsMatch(object? actual)
    {
        return actual is not null && Regex.IsMatch(actual.ToString()!, _pattern);
    }
}