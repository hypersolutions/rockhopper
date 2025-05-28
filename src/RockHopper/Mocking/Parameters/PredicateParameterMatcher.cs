using MockException = RockHopper.Mocking.Exceptions.MockException;

namespace RockHopper.Mocking.Parameters;

internal class PredicateParameterMatcher : ParameterMatcher
{
    private Delegate _predicate = () => {};

    public override bool IsMatch(object? actual)
    {
        try
        {
            return (bool)_predicate.DynamicInvoke(actual)!;
        }
        catch (Exception error)
        {
            throw new MockException(
                $"Unable to invoke the predicate inside the {nameof(PredicateParameterMatcher)}.", error);
        }
    }
    
    public override void SetValue(Delegate? predicate)
    {
        _predicate = (Delegate)predicate?.DynamicInvoke()!;
    }
}