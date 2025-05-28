using System.Diagnostics;
using System.Linq.Expressions;
using RockHopper.Mocking.Parameters;

// ReSharper disable UnusedMember.Global - Called by mock instance

namespace RockHopper.Mocking.Setup;

public abstract class SetupInfo
{
    private readonly List<Parameter> _parameters = [];

    public IEnumerable<Parameter> Parameters => _parameters.AsReadOnly();
    
    internal string Name { get; init; } = null!;

    internal string FullName { get; init; } = null!;
    
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] // Stops debugger inspection incrementing value
    internal ReturnValueList ReturnValues { get; } = new();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)] // Stops debugger inspection incrementing value
    internal Visitor Visits { get; } = new();
    
    [DebuggerBrowsable(DebuggerBrowsableState.Never)] // Stops debugger inspection incrementing value
    internal ExceptionList Exceptions { get; } = new();
    
    public object? HandleResponse(object?[]? args)
    {
        Visits.Increment();
        
        if (Exceptions.HasExceptions) throw Exceptions.GetNext();
        
        var returnValue = ReturnValues.GetNext();
        
        if (args is null || args.Length == 0) return returnValue;

        var parameters = Parameters.ToArray();
        
        var outAndRefParams = parameters.Where(p => p.Type is ParameterType.Out or ParameterType.Ref);

        foreach (var outAndRefParam in outAndRefParams)
        {
            if (outAndRefParam.Matcher is not ExactParameterMatcher exactParameterMatcher)
                throw new NotSupportedException("Out and ref parameters do not support non-exact matching pattern.");
            
            var index = Array.IndexOf(parameters, outAndRefParam);
            args[index] = exactParameterMatcher.GetValue();
        }

        return returnValue;
    }
    
    internal void AddParameter(Parameter parameter)
    {
        _parameters.Add(parameter);
    }
    
    protected static IEnumerable<Parameter> BuildParameters(LambdaExpression expression)
    {
        var parameters = new List<Parameter>();

        if (expression.Body is MethodCallExpression body)
        {
            var methodParameters = body.Method.GetParameters();

            for (var i = 0; i < body.Arguments.Count; i++)
            {
                var argument = body.Arguments[i];
                var paramInfo = methodParameters[i];

                var lambda = Expression.Lambda(argument, expression.Parameters);
                var compiledDelegate = lambda.Compile();
                
                var value = lambda.Parameters.Count == 0
                    ? compiledDelegate.DynamicInvoke()
                    : compiledDelegate.DynamicInvoke(new object[1]);
                parameters.Add(new Parameter
                {
                    Type = Parameter.GetParameterType(paramInfo),
                    Matcher = ParameterMatcherFactory.Create(lambda, value)
                });
            }
        }

        return parameters;
    }
}