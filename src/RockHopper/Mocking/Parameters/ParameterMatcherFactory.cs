using System.Linq.Expressions;
using System.Reflection;

namespace RockHopper.Mocking.Parameters;

internal static class ParameterMatcherFactory
{
    private static readonly Type _anyParameterMatcherType = typeof(AnyParameterMatcher);
    private static readonly Type _regexParameterMatcherType = typeof(RegexParameterMatcher);
    private static readonly Type _predicateParameterMatcherType = typeof(PredicateParameterMatcher);
    
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
            
            if (paramMatcherType == _anyParameterMatcherType && valueDelegate is null) 
                return new AnyParameterMatcher();
            
            if (paramMatcherType == _regexParameterMatcherType && valueDelegate is not null) 
                return new RegexParameterMatcher(valueDelegate);

            if (paramMatcherType == _predicateParameterMatcherType && valueDelegate is not null) 
                return new PredicateParameterMatcher(valueDelegate);
        }

        return new ExactParameterMatcher(value);
    }

    internal static ParameterMatcher Create<TValue>(Func<TValue?> valueFunc)
    {
        var paramMatcherType = GetParameterMatcherType(valueFunc.Method);
        
        if (paramMatcherType == _anyParameterMatcherType) return new AnyParameterMatcher();
        
        if (paramMatcherType == _regexParameterMatcherType) return new RegexParameterMatcher(valueFunc);

        if (paramMatcherType == _predicateParameterMatcherType) return new PredicateParameterMatcher(valueFunc);

        return new ExactParameterMatcher(valueFunc());
    }
    
    private static Type GetParameterMatcherType(MethodInfo? methodInfo)
    {
        if (methodInfo?.GetCustomAttributes(typeof(ParameterMatcherAttribute), false)
                .FirstOrDefault() is ParameterMatcherAttribute paramMatcherAttr)
        {
            return paramMatcherAttr.ParameterMatcherType;
        }

        return typeof(ExactParameterMatcher);
    }
}