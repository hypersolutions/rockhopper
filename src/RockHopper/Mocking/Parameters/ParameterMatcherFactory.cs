using System.Linq.Expressions;
using System.Reflection;

namespace RockHopper.Mocking.Parameters;

internal static class ParameterMatcherFactory
{
    internal static ParameterMatcher Create(LambdaExpression expression, object? value)
    {
        var methodCall = expression.Body as MethodCallExpression;
        var paramMatcherType = GetParameterMatcherType(methodCall?.Method);
        
        if (methodCall is not null)
        {
            Delegate? valueDelegate = null;
            
            if (methodCall.Arguments.Count == 1)
            {
                var predicate = methodCall.Arguments[0];
                valueDelegate = Expression.Lambda(predicate).Compile();
            }

            paramMatcherType.SetValue(valueDelegate);
            return paramMatcherType;
        }

        var matcher = new ExactParameterMatcher();
        matcher.SetValue(() => value);
        return matcher;
    }

    internal static ParameterMatcher Create<TValue>(Func<TValue?> valueFunc)
    {
        var paramMatcherType = new ExactParameterMatcher();
        paramMatcherType.SetValue(valueFunc);
        return paramMatcherType;
    }
    
    private static ParameterMatcher GetParameterMatcherType(MethodInfo? methodInfo)
    {
        if (methodInfo?.GetCustomAttributes(typeof(ParameterMatcherAttribute), false)
                .FirstOrDefault() is ParameterMatcherAttribute paramMatcherAttr)
        {
            return paramMatcherAttr.Create();
        }

        return new ExactParameterMatcher();
    }
}