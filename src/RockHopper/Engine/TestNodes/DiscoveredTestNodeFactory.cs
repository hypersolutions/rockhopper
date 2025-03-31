using System.Reflection;
using System.Text;
using Microsoft.Testing.Platform.Extensions.Messages;

namespace RockHopper.Engine.TestNodes;

internal static class DiscoveredTestNodeFactory
{
    internal static PlatformTestNode Create(
        Type testClassType, 
        MethodInfo method, 
        TestAttribute testAttr, 
        object?[]? argsOverride = null, 
        string? skipOverride = null)
    {
        var testNode = new PlatformTestNode
        {
            Uid = $"{testClassType.FullName}+{method.Name}",
            DisplayName = GetDisplayName(method, testAttr),
            TestClassType = testClassType,
            Method = method,
            Filename = testAttr.FilePath,
            LineNumber = testAttr.LineNumber,
            SkipMessage = testAttr.Skip ?? skipOverride,
            Args = testAttr.InlineArgs ?? argsOverride,
            TestMethodProperty = new TestMethodIdentifierProperty(
                method.DeclaringType!.Assembly.FullName!,
                method.DeclaringType.Namespace!,
                method.DeclaringType.Name,
                method.Name,
                method.GetParameters().Select(p => p.ParameterType.FullName).ToArray()!,
                method.ReturnType.FullName!)
        };

        testNode.Properties.Add(DiscoveredTestNodeStateProperty.CachedInstance);
        testNode.Properties.Add(testNode.TestMethodProperty);
        
        return testNode;
    }
    
    private static string GetDisplayName(MethodInfo method, TestAttribute testAttr)
    {
        var displayNameBuilder = new StringBuilder();
        displayNameBuilder.Append(method.Name);

        if (testAttr.InlineArgs?.Length > 0)
        {
            displayNameBuilder.Append($" ({string.Join(", ", testAttr.InlineArgs)})");
        }

        if (testAttr.Description is not null)
        {
            displayNameBuilder.Append($" - {testAttr.Description}");
        }
        
        return displayNameBuilder.ToString();
    }
}