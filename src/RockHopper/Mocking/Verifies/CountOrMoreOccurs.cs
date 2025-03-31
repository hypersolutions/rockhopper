using RockHopper.Exceptions;

namespace RockHopper.Mocking.Verifies;

internal class CountOrMoreOccurs : Occurs
{
    internal CountOrMoreOccurs(int count) : base(count)
    {
    }

    internal override void Assert(int actualCount)
    {
        if (actualCount < Count)
            throw new VerificationException($"Verification mismatch: Expected at least {Count}; Actual {actualCount}");
    }
}