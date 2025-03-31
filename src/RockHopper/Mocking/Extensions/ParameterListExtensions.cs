using RockHopper.Mocking.Parameters;

namespace RockHopper.Mocking.Extensions;

internal static class ParameterListExtensions
{
    internal static bool IsMatchFor(this IEnumerable<Parameter> parameters, params object?[] args)
    {
        var parameterList = parameters.ToList();
        
        if (parameterList.Count == 0) return true;
        
        if (args is { Length: 0 } && args.Length == parameterList.Count) return true;

        if (args.Length == parameterList.Count)
        {
            return !parameterList.Where((t, i) => !t.Matcher.IsMatch(args[i])).Any();
        }

        return false;
    }
}