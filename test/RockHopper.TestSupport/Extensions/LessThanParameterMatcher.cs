using RockHopper.Mocking.Parameters;

namespace RockHopper.TestSupport.Extensions;

internal sealed class LessThanParameterMatcher : ParameterMatcher
{
    private int _maxValue;
    
    public override bool IsMatch(object? actual)
    {
        return (int?)actual < _maxValue;
    }

    public override void SetValue(Delegate? predicate)
    {
        _maxValue = (int)predicate?.DynamicInvoke()!;
    }
}