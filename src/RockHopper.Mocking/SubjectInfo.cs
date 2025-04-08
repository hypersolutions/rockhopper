using RockHopper.Exceptions;

namespace RockHopper.Mocking;

internal sealed class SubjectInfo
{
    private List<Mock>? _mocks;
    private object? _subject;
        
    internal TSubject Subject<TSubject>()
    {
        if (_subject is not null)
        {
            return (TSubject)_subject;
        }
            
        var subjectType = typeof(TSubject);
        var ctor = subjectType.GetConstructors().First();
        _mocks ??= [];

        foreach (var parameter in ctor.GetParameters())
        {
            var mockType = typeof(Mock<>).MakeGenericType(parameter.ParameterType);
            var mock = (Mock)Activator.CreateInstance(mockType)!;
            _mocks.Add(mock);
        }

        var args = _mocks.Select(m => m.GetInstance()).ToArray();
        _subject = Activator.CreateInstance(subjectType, args)!
                   ?? throw new TestException($"Unable to create an instance of the subject of type {subjectType}.");

        return (TSubject)_subject;
    }
    
    internal Mock<TMock> Mock<TMock>() where TMock : class
    {
        var mock = _mocks?.FirstOrDefault(m => m.GetInstance() is TMock) 
                   ?? throw new TestException($"Unable to find a mock for {typeof(TMock)}.");

        return (Mock<TMock>)mock;
    }

    internal void VerifyAllMocks()
    {
        _mocks?.ForEach(m => m.VerifyAll());
    }
}