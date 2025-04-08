using MockException = RockHopper.Mocking.Exceptions.MockException;

namespace RockHopper.Mocking.Setup;

internal sealed class ReturnValueList
{
    private readonly List<(dynamic? Value, bool IsDeferred)> _returns = [];
    private int _index = -1;

    internal void Add(object? value, bool isDeferred = false)
    {
        _returns.Add((value, isDeferred));   
    }

    internal dynamic? GetNext()
    {
        if (_returns.Count == 0) return null;

        if (_index + 1 >= _returns.Count)
            throw new MockException("The return value sequence exceeds the request.");

        var currentReturn = _returns[++_index];
        return currentReturn.IsDeferred ? currentReturn.Value() : currentReturn.Value;
    }

    internal void Reset()
    {
        _index = -1;
    }
}