using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using RockHopper.Assertions.Exceptions;

namespace RockHopper.Assertions;

/// <summary>
/// Checks that boolean expectations match the actual value.
/// </summary>
[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ShouldBeBooleanExtensions
{
    /// <summary>
    /// The actual value should be true.
    /// </summary>
    /// <param name="actual">Actual value</param>
    /// <param name="customErrorMessage">Custom error message</param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldBeTrue([DoesNotReturnIf(false)] this bool actual, string? customErrorMessage = null)
    {
        if (!actual)
        {
            throw new ExpectedAndActualException<bool>(true, actual, customErrorMessage);
        }
    }

    /// <summary>
    /// The actual value should be false.
    /// </summary>
    /// <param name="actual">Actual value</param>
    /// <param name="customErrorMessage">Custom error message</param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldBeFalse([DoesNotReturnIf(true)] this bool actual, string? customErrorMessage = null)
    {
        if (actual)
        {
            throw new ExpectedAndActualException<bool>(false, actual, customErrorMessage);
        }
    }
}