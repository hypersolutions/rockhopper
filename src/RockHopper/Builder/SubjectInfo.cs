using RockHopper.Enums;
using RockHopper.Exceptions;
using RockHopper.Mocking;

namespace RockHopper.Builder;

/// <summary>
/// Defines the subject information for creating an instance of the subject and its mock dependencies.
/// </summary>
/// <typeparam name="TSubject"></typeparam>
public sealed class SubjectInfo<TSubject>
{
    private readonly List<Mock>? _mocks;

    internal SubjectInfo(SubjectBuilderFlags builderFlags, IConstructorSelector constructorSelector)
    {
        var subjectInfoCache = SubjectInfoCache.Get<TSubject>(constructorSelector, builderFlags);
        var parameterMocks = subjectInfoCache.BuildParameterMocks();
        var propertyMocks = subjectInfoCache.BuildPropertyMocks();
        
        Value = subjectInfoCache.CreateSubject<TSubject>(parameterMocks, propertyMocks);
        _mocks = subjectInfoCache.BuildMocks(parameterMocks, propertyMocks);
    }
    
    /// <summary>
    /// Gets the subject instance.
    /// </summary>
    public TSubject Value { get; }

    /// <summary>
    /// Find a mock dependency injected into the subject instance.
    /// </summary>
    /// <typeparam name="TMock">Mock type</typeparam>
    /// <returns>Mock instance if found</returns>
    /// <exception cref="TestException">Unable to find the mock type</exception>
    public Mock<TMock> GetMock<TMock>() where TMock : class
    {
        var mock = _mocks?.FirstOrDefault(m => m.GetInstance() is TMock) 
                   ?? throw new TestException($"Unable to find a mock for {typeof(TMock)}.");

        return (Mock<TMock>)mock;
    }

    /// <summary>
    /// Verifies all the mocks have had the setups called as per strict mock behaviour. This will also reset the visit counts
    /// and any return/exception sequences, allowing you to reuse during the test.
    /// </summary>
    public void VerifyAll()
    {
        _mocks?.ForEach(m => m.VerifyAll());
    }
}