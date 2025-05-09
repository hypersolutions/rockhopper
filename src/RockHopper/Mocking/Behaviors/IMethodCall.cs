namespace RockHopper.Mocking.Behaviors;

/// <summary>
/// Defines the members of the method calls interface.
/// </summary>
public interface IMethodCall : IVerifyCall
{
    /// <summary>
    /// The mocked type method or parameter throws an exception.
    /// </summary>
    /// <typeparam name="TException">Exception type</typeparam>
    /// <returns>Verify call</returns>
    IVerifyCall Throws<TException>() where TException : Exception, new();

    /// <summary>
    /// The mocked type method or parameter throws an exception.
    /// </summary>
    /// <param name="exception">Exception instance to throw</param>
    /// <returns>Verify call</returns>
    IVerifyCall Throws(Exception exception);
}