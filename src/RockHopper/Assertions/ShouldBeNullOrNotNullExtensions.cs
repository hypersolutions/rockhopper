using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using RockHopper.Assertions.Exceptions;

namespace RockHopper.Assertions;

/// <summary>
/// Checks that the actual value is null or not null.
/// </summary>
[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ShouldBeNullOrNotNullExtensions
{
    /// <summary>
    /// The actual value should be true.
    /// </summary>
    /// <param name="actual">Actual value</param>
    /// <param name="customErrorMessage">Custom error message</param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldBeNull<T>([DoesNotReturnIf(false)] this T? actual, string? customErrorMessage = null)
    {
        if (actual is not null)
        {
            throw new ActualNullStateException<T>(actual, true, customErrorMessage);
        }
    }

    /// <summary>
    /// The actual value should be false.
    /// </summary>
    /// <param name="actual">Actual value</param>
    /// <param name="customErrorMessage">Custom error message</param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldNotBeNull<T>([DoesNotReturnIf(true)] this T? actual, string? customErrorMessage = null)
    {
        if (actual is null)
        {
            throw new ActualNullStateException<T>(actual, false, customErrorMessage);
        }
    }
}