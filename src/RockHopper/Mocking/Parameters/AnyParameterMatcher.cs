namespace RockHopper.Mocking.Parameters;

internal class AnyParameterMatcher : ParameterMatcher
{
    public override bool IsMatch(object? actual)
    {
        return true;
    }

    public override void SetValue(Delegate? predicate)
    {
    }
}