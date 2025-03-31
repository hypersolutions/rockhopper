namespace RockHopper.Mocking.Parameters;

public abstract class ParameterMatcher
{
    public object? Value { get; protected init; }
    
    public abstract bool IsMatch(object? value);
}