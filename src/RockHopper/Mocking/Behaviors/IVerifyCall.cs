namespace RockHopper.Mocking.Behaviors;

/// <summary>
/// Defines the members of the verify calls interface.
/// </summary>
public interface IVerifyCall
{
    /// <summary>
    /// Expecting no call to be made.
    /// </summary>
    void NeverOccurs();

    /// <summary>
    /// Expecting a single call to be made.
    /// </summary>
    void OccursOnce();

    /// <summary>
    /// Expecting a single call to be made.
    /// </summary>
    /// <param name="count">Number of times to check the call was made</param>
    void OccursExactly(int count);

    /// <summary>
    /// Expecting a single call to be made.
    /// </summary>
    /// <param name="count">Number of times to check the call was made at least</param>
    void OccursAtLeast(int count);
}