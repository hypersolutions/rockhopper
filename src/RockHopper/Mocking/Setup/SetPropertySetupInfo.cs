using System.Linq.Expressions;
using RockHopper.Mocking.Extensions;

namespace RockHopper.Mocking.Setup;

internal sealed class SetPropertySetupInfo : SetupInfo
{
    internal SetPropertySetupInfo(LambdaExpression expression)
    {
        var setMethodInfo = expression.GetMethodInfoForSet();
        
        // Special-case for indexers
        Name = setMethodInfo.Name.Replace("get_Item", "set_Item");
        
        foreach (var parameter in BuildParameters(expression))
        {
            AddParameter(parameter);    
        }
    }
}