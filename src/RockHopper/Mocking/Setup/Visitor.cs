using RockHopper.Mocking.Verifies;

namespace RockHopper.Mocking.Setup;

internal sealed class Visitor
{
    private int _visitCount;

    internal void Increment()
    {
        _visitCount++;
    }

    internal Occurs Occurs { get; private set; } = Occurs.Exactly(1);

    internal void AddOccurs(Occurs occurs)
    {
        Occurs = occurs;
    }

    internal void VerifyOccurs()
    {
        Occurs.Assert(_visitCount);
        _visitCount = 0;
    }
}