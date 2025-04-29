using RockHopper.Builder;
using RockHopper.Enums;
using RockHopper.Exceptions;
using RockHopper.Mocking;

namespace RockHopper;

/// <summary>
/// Defines the subject information for creating an instance of the subject and its mock dependencies.
/// </summary>
/// <typeparam name="TSubject"></typeparam>
public sealed class TestSubject<TSubject>
{
    private readonly List<Mock>? _mocks;

    /// <summary>
    /// Create the subject info and mock dependency information.
    /// </summary>
    /// <param name="builderFlags">How to construct the subject</param>
    /// <param name="constructorSelector">How to choose the constructor - defaults to the first constructor</param>
    public TestSubject(
        SubjectBuilderFlags builderFlags = SubjectBuilderFlags.Constructor, 
        IConstructorSelector? constructorSelector = null)
    {
        constructorSelector ??= new DefaultConstructorSelector();
        var testSubjectCache = TestSubjectCache.Get<TSubject>(constructorSelector, builderFlags);
        var parameterMocks = testSubjectCache.BuildParameterMocks();
        var propertyMocks = testSubjectCache.BuildPropertyMocks();
        
        Value = testSubjectCache.CreateSubject<TSubject>(parameterMocks, propertyMocks);
        _mocks = testSubjectCache.MergeMocks(parameterMocks, propertyMocks);
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
    /// Verifies all the mocks have had the setups called as per strict mock behaviour. This will also reset the visit
    /// counts and any return/exception sequences, allowing you to reuse during the test.
    /// </summary>
    public void VerifyAll()
    {
        _mocks?.ForEach(m => m.VerifyAll());
    }

    /// <summary>
    /// Allows casting from the test subject to the subject instance.
    /// </summary>
    /// <param name="testSubject">Test subject</param>
    /// <returns>Subject being tested</returns>
    public static implicit operator TSubject(TestSubject<TSubject> testSubject)
    {
        return testSubject.Value;
    }
}