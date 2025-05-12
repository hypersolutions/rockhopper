using System.Linq.Expressions;
using System.Reflection;

namespace RockHopper.Mocking.Extensions;

internal static class LambdaExpressionExtensions
{
    internal static bool IsFunctionExpression(this LambdaExpression expression)
    {
        MethodInfo? getMethodInfo = null;

        if (expression.Body is MemberExpression) return getMethodInfo is not null;
        
        var methodCall = expression.Body as MethodCallExpression;
        getMethodInfo = methodCall?.Method;

        return getMethodInfo is not null;
    }
    
    internal static bool IsGetPropertyExpression(this LambdaExpression expression)
    {
        MethodInfo? getMethodInfo = null;

        if (expression.Body is not MemberExpression body) return getMethodInfo is not null;
        
        var propInfo = (PropertyInfo)body.Member;
        getMethodInfo = propInfo.GetMethod;

        return getMethodInfo is not null;
    }
    
    internal static bool IsSetPropertyExpression(this LambdaExpression expression)
    {
        MethodInfo? setMethodInfo = null;

        if (expression.Body is not MemberExpression body) return setMethodInfo is not null;
        
        var propInfo = (PropertyInfo)body.Member;
        setMethodInfo = propInfo.SetMethod;

        return setMethodInfo is not null;
    }

    internal static MethodInfo GetMethodInfoForGet(this LambdaExpression expression)
    {
        MethodInfo? getMethodInfo;
        
        if (expression.Body is not MemberExpression body)
        {
            var methodCall = expression.Body as MethodCallExpression;
            getMethodInfo = methodCall?.Method;
        }
        else
        {
            var propInfo = (PropertyInfo)body.Member;
            getMethodInfo = propInfo.GetMethod;
        }

        if (getMethodInfo is null)
            throw new ArgumentException("The property expression has no get.");

        return getMethodInfo;
    }
    
    internal static MethodInfo GetMethodInfoForSet(this LambdaExpression expression)
    {
        MethodInfo? setMethodInfo;
        
        if (expression.Body is not MemberExpression body)
        {
            var methodCall = expression.Body as MethodCallExpression;
            setMethodInfo = methodCall?.Method;
        }
        else
        {
            var propInfo = (PropertyInfo)body.Member;
            setMethodInfo = propInfo.SetMethod;
        }
        
        if (setMethodInfo is null)
            throw new ArgumentException("The property expression has no set.");

        return setMethodInfo;
    }
}