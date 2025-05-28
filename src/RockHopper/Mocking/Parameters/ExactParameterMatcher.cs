namespace RockHopper.Mocking.Parameters;

internal class ExactParameterMatcher : ParameterMatcher
{
    private object? _value;
    
    public override bool IsMatch(object? actual)
    {
        return Equals(_value, actual);
    }

    public object? GetValue()
    {
        return _value;
    }
    
    public override void SetValue(Delegate? predicate)
    {
        _value = predicate?.DynamicInvoke();
    }
}