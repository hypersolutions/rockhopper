using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RockHopper.Assertions.Exceptions;

namespace RockHopper.Assertions;

/// <summary>
/// Checks enumerable types.
/// </summary>
[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Never)]
public static class ShouldBeEnumerableExtensions
{
    /// <summary>
    /// Checks that only one entry is expected.
    /// </summary>
    /// <param name="list">List of items</param>
    /// <param name="customErrorMessage">Custom error message</param>
    /// <typeparam name="T">List type</typeparam>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldBeSingle<T>(this IEnumerable<T> list, string? customErrorMessage = null)
    {
        var count = list.Count();
        
        if (count != 1)
        {
            throw new ExpectedAndActualException<int>(1, count, customErrorMessage);
        }
    }

    /// <summary>
    /// Checks that n entries are expected.
    /// </summary>
    /// <param name="list">List of items</param>
    /// <param name="count">Number of entries expected</param>
    /// <param name="customErrorMessage">Custom error message</param>
    /// <typeparam name="T">List type</typeparam>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldContainCount<T>(this T[] list, int count, string? customErrorMessage = null)
    {
        if (list.Length != count)
        {
            throw new ExpectedAndActualException<int>(count, list.Length, customErrorMessage);
        }
    }
}