using RockHopper.Enums;
using RockHopper.Exceptions;
using RockHopper.Mocking;

namespace RockHopper.Builder;

internal sealed class SubjectInfo
{
    private readonly ReaderWriterLockSlim _subjectCreateLock = new();
    private List<Mock>? _mocks;
    private object? _subject;
        
    internal TSubject GetSubject<TSubject>(SubjectBuilderFlags builderFlags, IConstructorSelector constructorSelector)
    {
        try
        {
            _subjectCreateLock.EnterUpgradeableReadLock();
            
            if (_subject is not null)
            {
                return (TSubject)_subject;
            }

            try
            {
                _subjectCreateLock.EnterWriteLock();
                
                var subjectInfoCache = SubjectInfoCache.Get<TSubject>(constructorSelector, builderFlags);
                var parameterMocks = subjectInfoCache.BuildParameterMocks();
                var propertyMocks = subjectInfoCache.BuildPropertyMocks();
        
                _subject = subjectInfoCache.CreateSubject<TSubject>(parameterMocks, propertyMocks)!;
                _mocks = subjectInfoCache.BuildMocks(parameterMocks, propertyMocks);
        
                return (TSubject)_subject;
            }
            finally
            {
                _subjectCreateLock.ExitWriteLock();
            }
        }
        finally
        {
            _subjectCreateLock.ExitUpgradeableReadLock();
        }
    }
    
    internal Mock<TMock> GetMock<TMock>() where TMock : class
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