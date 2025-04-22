namespace RockHopper.Mocking.Parameters;

internal class ExactParameterMatcher : ParameterMatcher
{
    internal ExactParameterMatcher(object? expected = null)
    {
        Value = expected;
    }
    
    public override bool IsMatch(object? actual)
    {
        return Equals(Value, actual);
    }
}