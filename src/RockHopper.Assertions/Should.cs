using RockHopper.Assertions.Exceptions;

namespace RockHopper.Assertions;

/// <summary>
/// Checks static should assertions are expected.
/// </summary>
public static class Should
{
    /// <summary>
    /// Checks that the expected exception is thrown from an action.
    /// </summary>
    /// <param name="action">Action to invoke</param>
    /// <param name="customErrorMessage">Custom error message</param>
    /// <typeparam name="TException">Expected exception</typeparam>
    /// <returns></returns>
    public static Exception Throw<TException>(Action action, string? customErrorMessage = null) where TException : Exception
    {
        try
        {
            action();
        }
        catch (TException error)
        {
            return error;
        }
        catch (Exception)
        {
            // We got here so we should throw an exception to fail the test
        }
        
        throw new ExpectedErrorNotThrownException<TException>(customErrorMessage);
    }
    
    /// <summary>
    /// Checks that the expected exception is not thrown from an action.
    /// </summary>
    /// <param name="action">Action to invoke</param>
    /// <param name="customErrorMessage">Custom error message</param>
    /// <typeparam name="TException">Expected exception not thrown</typeparam>
    /// <returns></returns>
    public static void NotThrow<TException>(Action action, string? customErrorMessage = null) where TException : Exception
    {
        try
        {
            action();
        }
        catch (TException)
        {
            throw new ExpectedErrorThrownException<TException>(customErrorMessage);
        }
    }
    
    /// <summary>
    /// Checks that the expected exception is thrown from an action.
    /// </summary>
    /// <param name="action">Action to invoke</param>
    /// <param name="customErrorMessage">Custom error message</param>
    /// <typeparam name="TException">Expected exception</typeparam>
    /// <returns></returns>
    public static async Task<TException> ThrowAsync<TException>(Func<Task> action, string? customErrorMessage = null) where TException : Exception
    {
        try
        {
            await action();
        }
        catch (TException error)
        {
            return await Task.FromResult(error);
        }
        catch (Exception)
        {
            // We got here so we should throw an exception to fail the test
        }
        
        throw new ExpectedErrorNotThrownException<TException>(customErrorMessage);
    }
}