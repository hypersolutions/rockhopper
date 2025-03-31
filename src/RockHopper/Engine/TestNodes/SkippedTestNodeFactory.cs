using Microsoft.Testing.Platform.Extensions.Messages;

namespace RockHopper.Engine.TestNodes;

internal static class SkippedTestNodeFactory
{
    internal static PlatformTestNode Create(PlatformTestNode testNode, string skipMessage)
    {
        var newTestNode = new PlatformTestNode
        {
            Uid = testNode.Uid,
            DisplayName = testNode.DisplayName,
            TestClassType = testNode.TestClassType,
            Method = testNode.Method,
            SkipMessage = testNode.SkipMessage,
            Args = testNode.Args,
            TestMethodProperty = testNode.TestMethodProperty
        };

        newTestNode.Properties.Add(new SkippedTestNodeStateProperty(skipMessage));
        newTestNode.Properties.Add(testNode.TestMethodProperty);
        
        return newTestNode;
    }
}