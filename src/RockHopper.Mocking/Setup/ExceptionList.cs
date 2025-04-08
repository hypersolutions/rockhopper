using MockException = RockHopper.Mocking.Exceptions.MockException;

namespace RockHopper.Mocking.Setup;

internal sealed class ExceptionList
{
    private readonly List<Exception> _exceptions = [];
    private int _index = -1;

    internal void Add(Exception exception)
    {
        _exceptions.Add(exception);
    }

    internal bool HasExceptions => _exceptions.Count != 0;
    
    internal Exception GetNext()
    {
        if (_index + 1 >= _exceptions.Count)
            throw new MockException("The exception sequence exceeds the request.");

        return _exceptions[++_index];
    }

    internal void Reset()
    {
        _index = -1;
    }
}