using System.Reflection;
using Microsoft.Testing.Platform.Extensions.Messages;

// ReSharper disable UnusedAutoPropertyAccessor.Global - Used by IDEs to test navigation

namespace RockHopper.Engine.TestNodes;

internal sealed class PlatformTestNode : TestNode
{
    private readonly TestNodeExecutor _testNodeExecutor;
    
    internal PlatformTestNode()
    {
        _testNodeExecutor = new TestNodeExecutor(this);
    }
    
    internal required Type TestClassType { get; init; }
    
    internal required MethodInfo Method { get; init; }

    internal string Filename { get; init; } = string.Empty;
    
    internal int LineNumber { get; init; }
    
    internal string? SkipMessage { get; init; }

    internal bool IsSkipped => !string.IsNullOrWhiteSpace(SkipMessage);

    internal object?[]? Args { get; init; }
    
    internal TestMethodIdentifierProperty TestMethodProperty { get; init; } = null!;
    
    internal bool IsAwaitable => Method.ReturnType == typeof(Task);
    
    internal static PlatformTestNode Create(
        Type testClassType, 
        MethodInfo method, 
        TestAttribute testAttr, 
        object?[]? argsOverride = null, 
        string? skipOverride = null)
    {
        return DiscoveredTestNodeFactory.Create(testClassType, method, testAttr, argsOverride, skipOverride);
    }
    
    internal PlatformTestNode TransitionToInProgress()
    {
        return InProgressTestNodeFactory.Create(this);
    }
    
    internal PlatformTestNode TransitionToPassed()
    {
        return PassedTestNodeFactory.Create(this);
    }

    internal PlatformTestNode TransitionToFailed(Exception error)
    {
        return FailedTestNodeFactory.Create(this, error);
    }
    
    internal PlatformTestNode TransitionToSkipped(string skipMessage)
    {
        return SkippedTestNodeFactory.Create(this, skipMessage);
    }

    internal async Task ExecuteTestAsync(ExecutionContext context)
    {
        await _testNodeExecutor.ExecuteTestAsync(context);
    }

    internal string GetFullName()
    {
        return $"/{TestClassType.Assembly.GetName().Name}/{TestClassType.Namespace}/{TestClassType.Name}/{Method.Name}";
    }
}