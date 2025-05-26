using System.Linq.Expressions;
using RockHopper.Mocking.Extensions;

namespace RockHopper.Mocking.Setup;

internal sealed class GetPropertySetupInfo : SetupInfo
{
    internal GetPropertySetupInfo(LambdaExpression expression)
    {
        var getMethodInfo = expression.GetMethodInfoForGet();

        getMethodInfo.CheckMethodIsOverridable();
        
        Name = getMethodInfo.Name;

        FullName = $"{getMethodInfo.DeclaringType!.Name}.{Name.Replace("get_", string.Empty)}";

        foreach (var parameter in BuildParameters(expression))
        {
            AddParameter(parameter);    
        }
    }
}