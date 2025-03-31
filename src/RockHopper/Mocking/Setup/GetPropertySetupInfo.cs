using System.Linq.Expressions;
using RockHopper.Mocking.Extensions;

namespace RockHopper.Mocking.Setup;

internal sealed class GetPropertySetupInfo : SetupInfo
{
    internal GetPropertySetupInfo(LambdaExpression expression)
    {
        var getMethodInfo = expression.GetMethodInfoForGet();

        Name = getMethodInfo.Name;

        foreach (var parameter in BuildParameters(expression))
        {
            AddParameter(parameter);    
        }
    }
}