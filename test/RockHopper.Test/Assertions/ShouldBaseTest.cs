using System.Diagnostics.CodeAnalysis;
using RockHopper.Assertions.Exceptions;
// ReSharper disable PossibleIntendedRethrow - test pattern

namespace RockHopper.Test.Assertions;

[SuppressMessage("Usage", "CA2200:Rethrow to preserve stack details")]
public abstract class ShouldBaseTest
{
    protected static void ShouldThrow<T>(Action action, T expected, T actual)
    {
        try
        {
            action();
        }
        catch (Exception error) when (error is ExpectedAndActualException<T>)
        {
            // Passed
            return;
        }

        throw new ExpectedAndActualException<T>(expected, actual, "Failed to throw expected exception.");
    }
    
    protected static void ShouldNotThrow<T>(Action action)
    {
        try
        {
            action();
        }
        catch (Exception error) when (error is ExpectedAndActualException<T>)
        {
            throw error;
        }

        // Passed
    }
}