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
    /// Checks that no entries are expected.
    /// </summary>
    /// <param name="list">List of items</param>
    /// <param name="customErrorMessage">Custom error message</param>
    /// <typeparam name="T">List type</typeparam>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldBeEmpty<T>(this IEnumerable<T> list, string? customErrorMessage = null)
    {
        var actualCount = list.Count();
        
        if (actualCount != 0)
        {
            throw new ExpectedAndActualException<int>(0, actualCount, customErrorMessage);
        }
    }
    
    /// <summary>
    /// Checks that only one entry is expected.
    /// </summary>
    /// <param name="list">List of items</param>
    /// <param name="customErrorMessage">Custom error message</param>
    /// <typeparam name="T">List type</typeparam>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldBeSingle<T>(this IEnumerable<T> list, string? customErrorMessage = null)
    {
        var actualCount = list.Count();
        
        if (actualCount != 1)
        {
            throw new ExpectedAndActualException<int>(1, actualCount, customErrorMessage);
        }
    }

    /// <summary>
    /// Checks that n entries are expected.
    /// </summary>
    /// <param name="list">List of items</param>
    /// <param name="expectedCount">Number of entries expected</param>
    /// <param name="customErrorMessage">Custom error message</param>
    /// <typeparam name="T">List type</typeparam>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ShouldContainCount<T>(this IEnumerable<T> list, int expectedCount, string? customErrorMessage = null)
    {
        var actualCount = list.Count();
        
        if (actualCount != expectedCount)
        {
            throw new ExpectedAndActualException<int>(expectedCount, actualCount, customErrorMessage);
        }
    }
}