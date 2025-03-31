using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RockHopper.Assertions.Exceptions;

namespace RockHopper.Assertions;

// TODO: Complete others and fix assertion error thrown

/// <summary>
/// Compares the expected value with the actual value.
/// </summary>
[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ShouldBeComparableExtensions
{
    /// <summary>
    /// Checks that the actual value is greater than the expected value.
    /// </summary>
    /// <param name="actual">Actual value</param>
    /// <param name="expected">Expected value</param>
    /// <param name="customErrorMessage">Custom error message</param>
    /// <typeparam name="T">Type to assert</typeparam>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldBeGreaterThan<T>(this T? actual, T? expected, string? customErrorMessage = null) 
        where T : IComparable<T>?
    {
        if (actual?.CompareTo(expected) <= 0)
            throw new ExpectedAndActualException<T>(expected, actual, customErrorMessage);
    }
}