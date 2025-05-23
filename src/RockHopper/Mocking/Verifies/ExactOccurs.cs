using RockHopper.Mocking.Exceptions;

namespace RockHopper.Mocking.Verifies;

internal class ExactOccurs : Occurs
{
    internal ExactOccurs(int count) : base(count)
    {
    }

    internal override void Assert(string target, int actualCount)
    {
        if (Count != actualCount)
            throw new VerificationException(
                $"Verification mismatch: Expected {Count}; Actual {actualCount} for {target}.");
    }
}