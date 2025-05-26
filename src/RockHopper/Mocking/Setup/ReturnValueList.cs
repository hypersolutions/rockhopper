using MockException = RockHopper.Mocking.Exceptions.MockException;

namespace RockHopper.Mocking.Setup;

internal sealed class ReturnValueList
{
    private readonly List<object?> _returns = [];
    private int _index = -1;

    internal int Count => _returns.Count;
    
    internal void Add<TReturn>(TReturn? value)
    {
        _returns.Add(value);   
    }

    internal object? GetNext()
    {
        if (_returns.Count == 0) return null;

        if (_index + 1 >= _returns.Count)
            throw new MockException("The return value sequence exceeds the request.");

        var currentReturn = _returns[++_index];
        return GetValue(currentReturn);
    }

    internal void Reset()
    {
        _index = -1;
    }

    private static object? GetValue(object? currentReturn)
    {
        if (currentReturn is Delegate func)
        {
            return func.DynamicInvoke();
        }
        
        return currentReturn;
    }
}