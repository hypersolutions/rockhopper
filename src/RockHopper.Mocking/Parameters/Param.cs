// ReSharper disable UnusedParameter.Global
namespace RockHopper.Mocking.Parameters;

/// <summary>
/// Mock helper for describing a parameter.
/// </summary>
public static class Param
{
    /// <summary>
    /// Indicates that any value of the type is allowed and will resolve.
    /// </summary>
    /// <typeparam name="T">Parameter type</typeparam>
    [ParameterMatcher(typeof(AnyParameterMatcher))]
    public static T IsAny<T>()
    {
        return default!;
    }

    /// <summary>
    /// Provides a predicate approach to determining a match for a parameter.
    /// </summary>
    /// <typeparam name="T">Parameter type</typeparam>
    /// <param name="predicate">Predicate</param>
    [ParameterMatcher(typeof(PredicateParameterMatcher))]
    public static T Is<T>(Func<T, bool> predicate)
    {
        return default!;
    }

    /// <summary>
    /// Provides a regex pattern approach to determining a match for a parameter.
    /// </summary>
    /// <param name="pattern">Regex pattern to match</param>
    [ParameterMatcher(typeof(RegexParameterMatcher))]
    public static string IsRegex(string pattern)
    {
        return null!;
    }
}