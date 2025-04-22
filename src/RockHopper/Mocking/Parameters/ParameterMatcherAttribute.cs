namespace RockHopper.Mocking.Parameters;

[AttributeUsage(AttributeTargets.Method)]
internal class ParameterMatcherAttribute : Attribute
{
    private static readonly Type _parameterMatcherType = typeof(ParameterMatcher);
    
    internal ParameterMatcherAttribute(Type type)
    {
        if (!_parameterMatcherType.IsAssignableFrom(type))
            throw new ArgumentException($"Type {type} is not derived from ParameterMatcher.");

        ParameterMatcherType = type;
    }

    internal Type ParameterMatcherType { get; }
}