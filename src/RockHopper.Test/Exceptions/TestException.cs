namespace RockHopper.Test.Exceptions;

/// <summary>
/// Defines general test framework exception.
/// </summary>
public class TestException : Exception
{
    /// <summary>
    /// Initializes a new instance of the class.
    /// </summary>
    /// <param name="message">Error message</param>
    internal TestException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the class.
    /// </summary>
    /// <param name="message">Error message</param>
    /// <param name="innerException">Inner exception</param>
    internal TestException(string message, Exception innerException) : base(message, innerException)
    {
    }
}