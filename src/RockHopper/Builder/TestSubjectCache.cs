using System.Collections.Concurrent;
using System.Reflection;
using RockHopper.Enums;
using RockHopper.Exceptions;
using RockHopper.Mocking;

namespace RockHopper.Builder;

internal static class TestSubjectCache
{
    private static readonly ConcurrentDictionary<string, SubjectInfoCacheInfo> _bag = new();

    internal static SubjectInfoCacheInfo Get<TSubject>(IConstructorSelector constructorSelector,
        SubjectBuilderFlags builderFlags)
    {
        var key = $"{typeof(TSubject).FullName}.{constructorSelector.GetType().FullName}.{builderFlags}";
        return _bag.GetOrAdd(key, _ => new SubjectInfoCacheInfo(
            typeof(TSubject), constructorSelector.GetConstructor<TSubject>(), builderFlags));
    }
    
    internal class SubjectInfoCacheInfo
    {
        private readonly ConstructorInfo _constructor;
        private readonly List<ParameterInfo> _parameters = [];
        private readonly List<PropertyInfo> _properties = [];
        
        internal SubjectInfoCacheInfo(Type subjectType, ConstructorInfo constructor, SubjectBuilderFlags builderFlags)
        {
            _constructor = constructor;

            AddParameters(builderFlags);
            AddProperties(subjectType, builderFlags);
        }

        internal TSubject CreateSubject<TSubject>(ParameterMocks parameterMocks, PropertyMocks propertyMocks)
        {
            var subject = (TSubject)_constructor.Invoke(parameterMocks.GetInstances());

            var propertyMockInstances = propertyMocks.GetInstances();
            
            for (var i = 0; i < _properties.Count; i++)
            {
                _properties[i].SetValue(subject, propertyMockInstances[i]);
            }

            return subject;
        }

        internal ParameterMocks BuildParameterMocks()
        {
            var parameterMocks = new ParameterMocks();

            foreach (var parameter in _parameters)
            {
                var mockType = typeof(Mock<>).MakeGenericType(parameter.ParameterType);
                var mock = (Mock)Activator.CreateInstance(mockType)!;
                parameterMocks.Add(parameter, mock);
            }

            return parameterMocks;
        }
        
        internal PropertyMocks BuildPropertyMocks()
        {
            var propertyMocks = new PropertyMocks();

            foreach (var property in _properties)
            {
                var mockType = typeof(Mock<>).MakeGenericType(property.PropertyType);
                var mock = (Mock)Activator.CreateInstance(mockType)!;
                propertyMocks.Add(property, mock);
            }
            
            return propertyMocks;
        }

        internal List<Mock> MergeMocks(ParameterMocks parameterMocks, PropertyMocks propertyMocks)
        {
            List<Mock> mocks = [];
            mocks.AddRange(parameterMocks.Select(m => m.Value));
            mocks.AddRange(propertyMocks.Select(m => m.Value));
            return mocks;
        }

        private void AddParameters(SubjectBuilderFlags builderFlags)
        {
            if (HasFlag(builderFlags, SubjectBuilderFlags.Constructor))
            {
                foreach (var parameter in _constructor.GetParameters())
                {
                    _parameters.Add(parameter);
                }
            }
        }

        private void AddProperties(Type subjectType, SubjectBuilderFlags builderFlags)
        {
            if (HasFlag(builderFlags, SubjectBuilderFlags.Property))
            {
                CheckForParameterlessConstructor(builderFlags);
            
                const BindingFlags propertyFlags = BindingFlags.Instance | BindingFlags.Public;

                foreach (var property in subjectType.GetProperties(propertyFlags).Where(PropertyTypeIsInterface))
                {
                    _properties.Add(property);
                }
            }
        }

        private void CheckForParameterlessConstructor(SubjectBuilderFlags builderFlags)
        {
            if (!HasFlag(builderFlags, SubjectBuilderFlags.Constructor) && _constructor.GetParameters().Length > 0)
            {
                throw new TestException(
                    "There is no parameterless constructor for the subject using property injection only.");
            }
        }
        
        private static bool HasFlag(SubjectBuilderFlags flags, SubjectBuilderFlags expectedFlag)
        {
            return (flags & expectedFlag) == expectedFlag;
        }
        
        private static bool PropertyTypeIsInterface(PropertyInfo propertyInfo)
        {
            return (propertyInfo.PropertyType.IsInterface || propertyInfo.PropertyType.IsAbstract) && propertyInfo.CanWrite;
        }
    }
}