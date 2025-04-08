using System.Linq.Expressions;

namespace RockHopper.Mocking.Setup;

internal sealed class MethodSetupInfo : SetupInfo
{
    internal MethodSetupInfo(LambdaExpression expression)
    {
        if (expression.Body is not MethodCallExpression body)
            throw new ArgumentException("Unable to get method/function from expression.");
        
        Name = body.Method.Name;
        
        foreach (var parameter in BuildParameters(expression))
        {
            AddParameter(parameter);    
        }
    }
}