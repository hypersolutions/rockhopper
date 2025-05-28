namespace RockHopper.Mocking.Parameters;

/// <summary>
/// Defines the parameter matcher base class for providing different parameter matching patterns.
/// </summary>
public abstract class ParameterMatcher
{
    /// <summary>
    /// Determines if the value provided during the call to the method or function matches the defined condition of the
    /// derived parameter matcher implementation. 
    /// </summary>
    /// <param name="value">Value to check</param>
    /// <returns>True if matches</returns>
    public abstract bool IsMatch(object? value);

    /// <summary>
    /// Sets the value to use to match incoming parameter values passed to the <i>IsMatch</i> method.
    /// </summary>
    /// <param name="predicate">Predicate containing condition</param>
    public abstract void SetValue(Delegate? predicate);
}