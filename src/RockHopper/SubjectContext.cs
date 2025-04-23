using RockHopper.Builder;
using RockHopper.Enums;
using RockHopper.Exceptions;
using RockHopper.Mocking;

namespace RockHopper;

/// <summary>
/// Subject context for constructing classes under test with their mocks.
/// </summary>
public class SubjectContext : ISubjectContext
{
    private static readonly AsyncLocal<SubjectInfo> _testInfo = new();

    /// <summary>
    /// Gets the current subject context for the scope of the test.
    /// </summary>
    public static readonly SubjectContext Current = new();

    private SubjectContext()
    {
    }
    
    public TSubject CreateSubject<TSubject>(
        SubjectBuilderFlags builderFlags = SubjectBuilderFlags.Constructor, 
        IConstructorSelector? constructorSelector = null)
    {
        _testInfo.Value ??= new SubjectInfo();

        constructorSelector ??= new DefaultConstructorSelector();
        
        return _testInfo.Value.GetSubject<TSubject>(builderFlags, constructorSelector);
    }
    
    public Mock<TMock> GetMock<TMock>() where TMock : class
    {
        if (_testInfo.Value is null)
        {
            throw new TestException("No test mocks exist. You need to call the CreateSubject first.");
        }

        return _testInfo.Value.GetMock<TMock>();
    }
    
    public void VerifyAll()
    {
        _testInfo.Value?.VerifyAllMocks();
    }
}