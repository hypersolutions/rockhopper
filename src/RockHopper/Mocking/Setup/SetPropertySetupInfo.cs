using System.Linq.Expressions;
using RockHopper.Mocking.Extensions;
using RockHopper.Mocking.Parameters;

namespace RockHopper.Mocking.Setup;

internal sealed class SetPropertySetupInfo<TValue> : SetupInfo
{
    internal SetPropertySetupInfo(LambdaExpression expression, Func<TValue?> valueFunc)
    {
        var setMethodInfo = expression.GetMethodInfoForSet();
        
        // Special-case for indexers
        Name = setMethodInfo.Name.Replace("get_Item", "set_Item");
        
        foreach (var parameter in BuildParameters(expression))
        {
            AddParameter(parameter);    
        }
        
        AddParameter(new Parameter { Matcher = ParameterMatcherFactory.Create(valueFunc), Type = ParameterType.In });
    }
}