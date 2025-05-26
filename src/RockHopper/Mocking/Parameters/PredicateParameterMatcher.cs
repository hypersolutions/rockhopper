using MockException = RockHopper.Mocking.Exceptions.MockException;

namespace RockHopper.Mocking.Parameters;

internal class PredicateParameterMatcher : ParameterMatcher
{
    private readonly Delegate _predicate;

    internal PredicateParameterMatcher(Delegate predicate)
    {
        _predicate = (Delegate)predicate.DynamicInvoke()!;
    }
    
    public override bool IsMatch(object? actual)
    {
        try
        {
            return (bool)_predicate.DynamicInvoke(actual)!;
        }
        catch (Exception error)
        {
            throw new MockException("Unable to invoke the predicate inside the PredicateParameterMatcher.", error);
        }
    }
}