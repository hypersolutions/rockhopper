using RockHopper.Mocking.Setup;

namespace RockHopper.Mocking.Behaviors;

/// <summary>
/// Defines the setup method call behaviour.
/// </summary>
public sealed class MethodCall : VerifyCall
{
    private readonly SetupInfo _setupInfo;

    internal MethodCall(SetupInfo setupInfo) : base(setupInfo)
    {
        _setupInfo = setupInfo;
    }
    
    /// <summary>
    /// The mocked type method or parameter throws an exception.
    /// </summary>
    /// <typeparam name="TException">Exception type</typeparam>
    /// <returns>Verify call</returns>
    public VerifyCall Throws<TException>() where TException : Exception, new()
    {
        return Throws(new TException());
    }

    /// <summary>
    /// The mocked type method or parameter throws an exception.
    /// </summary>
    /// <param name="exception">Exception instance to throw</param>
    /// <returns>Verify call</returns>
    public VerifyCall Throws(Exception exception)
    {
        ArgumentNullException.ThrowIfNull(exception);

        _setupInfo.Exceptions.Add(exception);

        return this;
    }
}