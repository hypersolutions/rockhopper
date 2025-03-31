using System.Reflection;

namespace RockHopper.Mocking.Parameters;

public class Parameter
{
    public required ParameterMatcher Matcher { get; init; }
    
    public required ParameterType Type { get; init; }
    
    internal static ParameterType GetParameterType(ParameterInfo paramInfo)
    {
        if (paramInfo.IsOut) return ParameterType.Out;
        
        return paramInfo.ParameterType.IsByRef ? ParameterType.Ref : ParameterType.In;
    }
}