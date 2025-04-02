using System.Reflection;
using RockHopper.Engine.TestNodes;
using RockHopper.Exceptions;
using RockHopper.Extensions;

namespace RockHopper.Engine;

internal sealed class TestNodeExecutor
{
    private readonly PlatformTestNode _testNode;

    public TestNodeExecutor(PlatformTestNode testNode)
    {
        _testNode = testNode;
    }
    
    internal async Task ExecuteTestAsync(ExecutionContext context)
    {
        object? testClassInstance = null;
        
        try
        {
            TestContext.InitCurrent(_testNode, context);
            
            testClassInstance = Activator.CreateInstance(_testNode.TestClassType);

            var args = ConvertArgs(_testNode.Method, _testNode.Args);
            
            if (_testNode.IsAwaitable)
            {
                await (Task)_testNode.Method.Invoke(testClassInstance, args)!;
            }
            else
            {
                _testNode.Method.Invoke(testClassInstance, args);
            }
        }
        finally
        {
            TestContext.VerifyAll();

            if (testClassInstance is not null)
            {
                await testClassInstance.Dispose();
            }
        }
    }

    private static object?[] ConvertArgs(MethodInfo method, object?[]? args)
    {
        try
        {
            if (args is null || args.Length == 0) return [];

            var parameters = method.GetParameters();

            return args.Select((t, i) => Convert.ChangeType(t, parameters[i].ParameterType)).ToArray();
        }
        catch (Exception error)
        {
            throw new TestException($"Unable to change an argument value to the parameter type for {method.Name}.", error);
        }
    }
}