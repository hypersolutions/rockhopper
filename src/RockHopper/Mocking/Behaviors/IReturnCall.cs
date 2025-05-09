namespace RockHopper.Mocking.Behaviors;

/// <summary>
/// Defines the members of the return calls interface.
/// </summary>
public interface IReturnCall<in TReturn> : IMethodCall
{
    /// <summary>
    /// The mocked type returns the values as a sequence.
    /// </summary>
    /// <param name="returnValues">Value to return</param>
    IVerifyCall Returns(params TReturn[] returnValues);

    /// <summary>
    /// The mocked type returns the resolved value at the point in which it is called.
    /// </summary>
    /// <param name="functions">Func to call</param>
    /// <returns>Verify call</returns>
    IVerifyCall Returns(params Func<TReturn?>[] functions);

    /// <summary>
    /// The mocked type returns the async values as a sequence.
    /// </summary>
    /// <param name="returnValues">Value to return</param>
    /// <returns>Verify call</returns>
    IVerifyCall ReturnsAsync(params TReturn?[] returnValues);
}