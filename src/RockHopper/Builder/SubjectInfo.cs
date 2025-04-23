using System.Reflection;
using RockHopper.Enums;
using RockHopper.Exceptions;
using RockHopper.Mocking;

namespace RockHopper.Builder;

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
            
        var subjectType = typeof(TSubject); // TODO: Cache
        
        var ctor = constructorSelector.GetConstructor<TSubject>(); // TODO: Cache? Always use the same ctor for the type?
        _mocks ??= [];
        var ctorMocks = new ParameterMocks();
        var propMocks = new PropertyMocks();

        if (HasFlag(builderFlags, SubjectBuilderFlags.Constructor))
        {
            foreach (var parameter in ctor.GetParameters()) // TODO: Potential cache
            {
                var mockType = typeof(Mock<>).MakeGenericType(parameter.ParameterType);
                var mock = (Mock)Activator.CreateInstance(mockType)!;
                ctorMocks.Add(parameter, mock);
            }
        }

        if (HasFlag(builderFlags, SubjectBuilderFlags.Property))
        {
            // Check: Is the constructor parameterless if we are only using property mocks?
            if (!HasFlag(builderFlags, SubjectBuilderFlags.Constructor)) // TODO: Potential cache
            {
                if (ctor.GetParameters().Length > 0)
                {
                    throw new TestException(
                        "There is no parameterless constructor for the subject using property injection only.");
                }
            }
            
            const BindingFlags propertyFlags = BindingFlags.Instance | BindingFlags.Public;

            foreach (var property in subjectType.GetProperties(propertyFlags).Where(PropertyTypeIsInterface)) // TODO: Potential cache
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