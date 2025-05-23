using RockHopper.Mocking.Verifies;

namespace RockHopper.Mocking.Setup;

internal sealed class Visitor
{
    private int _visitCount;
    private string _target = string.Empty;

    internal void Increment()
    {
        _visitCount++;
    }
    
    internal Occurs Occurs { get; private set; } = Occurs.Exactly(1);

    internal void AddOccurs(string target, Occurs occurs)
    {
        _target = target;
        Occurs = occurs;
    }

    internal void VerifyOccurs()
    {
        Occurs.Assert(_target, _visitCount);
        _visitCount = 0;
    }
}