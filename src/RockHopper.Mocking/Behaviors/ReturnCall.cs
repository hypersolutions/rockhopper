using RockHopper.Mocking.Setup;

namespace RockHopper.Mocking.Behaviors;

/// <summary>
/// Defines the setup return call behaviour.
/// </summary>
/// <typeparam name="TReturn">Return type</typeparam>
public sealed class ReturnCall<TReturn>
{
    private readonly SetupInfo _setupInfo;

    internal ReturnCall(SetupInfo setupInfo)
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

        return new VerifyCall(_setupInfo);
    }
    
    /// <summary>
    /// The mocked type returns the values as a sequence.
    /// </summary>
    /// <param name="returnValues">Value to return</param>
    public VerifyCall Returns(params TReturn[] returnValues)
    {
        foreach (var returnValue in returnValues)
        {
            _setupInfo.ReturnValues.Add(returnValue);
        }

        return new VerifyCall(_setupInfo);
    }
    
    /// <summary>
    /// The mocked type returns the resolved value at the point in which it is called.
    /// </summary>
    /// <param name="functions">Func to call</param>
    /// <returns>Verify call</returns>
    public VerifyCall Returns(params Func<TReturn>[] functions)
    {
        foreach (var function in functions)
        {
            _setupInfo.ReturnValues.Add(function, true);
        }
        
        return new VerifyCall(_setupInfo);
    }
    
    /// <summary>
    /// The mocked type returns the async values as a sequence.
    /// </summary>
    /// <param name="returnValues">Value to return</param>
    /// <returns>Verify call</returns>
    public VerifyCall ReturnsAsync(params TReturn[] returnValues)
    {
        foreach (var returnValue in returnValues)
        {
            _setupInfo.ReturnValues.Add(Task.FromResult(returnValue));
        }
        
        return new VerifyCall(_setupInfo);
    }
}