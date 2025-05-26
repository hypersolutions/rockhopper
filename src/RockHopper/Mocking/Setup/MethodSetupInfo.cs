using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using RockHopper.Mocking.Extensions;

namespace RockHopper.Mocking.Setup;

internal sealed class MethodSetupInfo : SetupInfo
{
    internal MethodSetupInfo(LambdaExpression expression)
    {
        if (expression.Body is not MethodCallExpression body)
            throw new ArgumentException("Unable to get method/function from expression.");

        body.Method.CheckMethodIsOverridable();
        
        Name = body.Method.Name;

        FullName = GetFullName(body.Method);

        ReturnTypeIsTask = body.Method.ReturnType == typeof(Task) ||
                           (body.Method.ReturnType.IsGenericType &&
                            body.Method.ReturnType.GetGenericTypeDefinition() == typeof(Task<>));
        
        ReturnTypeIsValueTask = body.Method.ReturnType == typeof(ValueTask) ||
                           (body.Method.ReturnType.IsGenericType &&
                            body.Method.ReturnType.GetGenericTypeDefinition() == typeof(ValueTask<>));
        
        foreach (var parameter in BuildParameters(expression))
        {
            AddParameter(parameter);    
        }
    }

    internal bool ReturnTypeIsTask { get; }
    
    internal bool ReturnTypeIsValueTask { get; }
    
    private static string GetFullName(MethodInfo method)
    {
        var fullName = new StringBuilder();
        fullName.Append(method.DeclaringType!.Name);
        fullName.Append('.');
        fullName.Append(method.Name);

        var parameters = method.GetParameters();

        if (parameters.Length > 0)
        {
            fullName.Append('(');
            fullName.Append(string.Join(", ", parameters.Select(p => p.ParameterType.Name)));
            fullName.Append(')');
        }
        
        return fullName.ToString();
    }
}