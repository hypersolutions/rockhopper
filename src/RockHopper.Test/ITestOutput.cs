namespace RockHopper.Test;

/// <summary>
/// Defines an test output.
/// </summary>
public interface ITestOutput
{
    /// <summary>
    /// Write a single line message.
    /// </summary>
    /// <param name="message">Message to write</param>
    void WriteLine(string message);
}