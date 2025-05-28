namespace RockHopper.Mocking.Parameters;

[AttributeUsage(AttributeTargets.Method)]
public sealed class ParameterMatcherAttribute : Attribute
{
    private readonly Type _parameterMatcherType;
    private static readonly Type _parameterMatcherBaseType = typeof(ParameterMatcher);
    
    public ParameterMatcherAttribute(Type type)
    {
        if (!_parameterMatcherBaseType.IsAssignableFrom(type))
            throw new ArgumentException($"Type {type} is not derived from ParameterMatcher.");

        _parameterMatcherType = type;
    }

    internal ParameterMatcher Create()
    {
        return (ParameterMatcher)Activator.CreateInstance(_parameterMatcherType)!;
    }
}