using RockHopper.Builder;
using RockHopper.Enums;
using RockHopper.Exceptions;
using RockHopper.Mocking;

namespace RockHopper;

/// <summary>
/// Defines the members of the subject context interface.
/// </summary>
public interface ISubjectContext
{
    /// <summary>
    /// Creates a subject and any mocks for a test. If called multiple times during the test, the same subject instance
    /// will be returned.
    /// </summary>
    /// <param name="builderFlags">How to construct the subject mocks</param>
    /// <param name="constructorSelector">How to find the constructor to use when creating the subject</param>
    /// <typeparam name="TSubject">Class under test to create</typeparam>
    /// <returns>Created instance of class under test</returns>
    TSubject CreateSubject<TSubject>(
        SubjectBuilderFlags builderFlags = SubjectBuilderFlags.Constructor, 
        IConstructorSelector? constructorSelector = null);

    /// <summary>
    /// Gets a mock that was injected into the created class under test. <b>Important</b> that you call CreateSubject first.
    /// </summary>
    /// <typeparam name="TMock">Mock to get that was injected into the class under test</typeparam>
    /// <returns>Created mock</returns>
    /// <exception cref="TestException">If the class under test has not been created or the mock cannot be found</exception>
    Mock<TMock> GetMock<TMock>() where TMock : class;

    /// <summary>
    /// This will verify all the mocks with setup expectations are called.
    /// </summary>
    void VerifyAll();
}