using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RockHopper.Assertions.Exceptions;

namespace RockHopper.Assertions;

/// <summary>
/// Checks that the expected type matches the actual type.
/// </summary>
[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ShouldBeOfTypeExtensions
{
    /// <summary>
    /// The actual type matches the expected type.
    /// </summary>
    /// <param name="actual">Actual value</param>
    /// <param name="customErrorMessage">Custom error message</param>
    /// <typeparam name="TType">Type to expect</typeparam>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldBeOfType<TType>(this object actual, string? customErrorMessage = null)
    {
        if (actual.GetType() != typeof(TType))
            throw new ExpectedAndActualTypeException(typeof(TType), actual.GetType(), customErrorMessage);
    }
}