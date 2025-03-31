using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RockHopper.Assertions.Exceptions;

namespace RockHopper.Assertions;

/// <summary>
/// Checks that the expected value matches the actual value.
/// </summary>
[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ShouldBeExtensions
{
    /// <summary>
    /// The actual value for match the expected value.
    /// </summary>
    /// <param name="actual">Actual value</param>
    /// <param name="expected">Expected value</param>
    /// <param name="customErrorMessage">Custom error message</param>
    /// <typeparam name="T">Type to assert</typeparam>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldBe<T>(this T? actual, T? expected, string? customErrorMessage = null)
    {
        // TODO: Some work to handle lots of other cases here!
        
        // Collections should be compared with another method
        
        if (actual is null && expected is not null || actual is not null && expected is null)
            throw new ExpectedAndActualException<T>(expected, actual, customErrorMessage);
        
        if (actual is not null && expected is not null && !expected.Equals(actual))
            throw new ExpectedAndActualException<T>(expected, actual, customErrorMessage);
    }
}