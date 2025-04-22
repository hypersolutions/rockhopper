using System.Reflection;
using RockHopper.Exceptions;
using RockHopper.Mocking;

namespace RockHopper;

internal sealed class SubjectInfo
{
    private List<Mock>? _mocks;
    private object? _subject;
        
    internal TSubject GetSubject<TSubject>(SubjectBuilderFlags builderFlags, IConstructorSelector constructorSelector)
    {
        if (_subject is not null)
        {
            return (TSubject)_subject;
        }
            
        var subjectType = typeof(TSubject);
        
        var ctor = constructorSelector.GetConstructor<TSubject>();
        _mocks ??= [];
        var ctorMocks = new ParameterMocks();
        var propMocks = new PropertyMocks();

        if (HasFlag(builderFlags, SubjectBuilderFlags.Constructor))
        {
            foreach (var parameter in ctor.GetParameters())
            {
                var mockType = typeof(Mock<>).MakeGenericType(parameter.ParameterType);
                var mock = (Mock)Activator.CreateInstance(mockType)!;
                ctorMocks.Add(parameter, mock);
            }
        }

        if (HasFlag(builderFlags, SubjectBuilderFlags.Property))
        {
            // Check: Is the constructor parameterless if we are only using property mocks?
            if (!HasFlag(builderFlags, SubjectBuilderFlags.Constructor))
            {
                if (ctor.GetParameters().Length > 0)
                {
                    throw new TestException(
                        "There is no parameterless constructor for the subject using property injection only.");
                }
            }
            
            const BindingFlags propertyFlags = BindingFlags.Instance | BindingFlags.Public;

            foreach (var property in subjectType.GetProperties(propertyFlags).Where(PropertyTypeIsInterface))
            {
                var mockType = typeof(Mock<>).MakeGenericType(property.PropertyType);
                var mock = (Mock)Activator.CreateInstance(mockType)!;
                propMocks.Add(property, mock);
            }
        }

        var args = ctorMocks.Select(m => m.Value.GetInstance()).ToArray();
        _subject = Activator.CreateInstance(subjectType, args)
                   ?? throw new TestException($"Unable to create an instance of the subject of type {subjectType}.");

        foreach (var propMock in propMocks)
        {
            propMock.Key.SetValue(_subject, propMock.Value.GetInstance());
        }
        
        _mocks.AddRange(ctorMocks.Select(m => m.Value));
        _mocks.AddRange(propMocks.Select(m => m.Value));
        
        return (TSubject)_subject;
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
    
    private static bool HasFlag(SubjectBuilderFlags flags, SubjectBuilderFlags expectedFlag)
    {
        return (flags & expectedFlag) == expectedFlag;
    }
    
    private static bool PropertyTypeIsInterface(PropertyInfo propertyInfo)
    {
        return (propertyInfo.PropertyType.IsInterface || propertyInfo.PropertyType.IsAbstract) && propertyInfo.CanWrite;
    }
    
    private sealed class ParameterMocks : Dictionary<ParameterInfo, Mock>;
    
    private sealed class PropertyMocks : Dictionary<PropertyInfo, Mock>;
}

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
public class SubjectContext : ISubjectContext
{
    private static readonly AsyncLocal<SubjectInfo> _testInfo = new();

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

/// <summary>
/// List of options to create a subject with mocks. These can be combined.
/// </summary>
[Flags]
public enum SubjectBuilderFlags
{
    /// <summary>
    /// Create mocks for interfaces defined in the constructor.
    /// </summary>
    Constructor = 1,
    
    /// <summary>
    /// Create mocks for interfaces defined on any public properties that support set or init.
    /// </summary>
    Property = 2,
    
    /// <summary>
    /// Create with both constructor and property matches.
    /// </summary>
    All = 3
}

/// <summary>
/// Defines the interface for selecting a constructor in the subject builder.
/// </summary>
public interface IConstructorSelector
{
    /// <summary>
    /// Gets a constructor for the subject type.
    /// </summary>
    /// <typeparam name="TSubject">Subject type</typeparam>
    /// <returns>Constructor info</returns>
    ConstructorInfo GetConstructor<TSubject>();
}

internal sealed class DefaultConstructorSelector : IConstructorSelector
{
    public ConstructorInfo GetConstructor<TSubject>()
    {
        return typeof(TSubject).GetConstructors().First();
    }
}