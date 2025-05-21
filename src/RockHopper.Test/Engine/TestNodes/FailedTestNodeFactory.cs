using Microsoft.Testing.Platform.Extensions.Messages;

namespace RockHopper.Test.Engine.TestNodes;

internal static class FailedTestNodeFactory
{
    internal static PlatformTestNode Create(PlatformTestNode testNode, Exception error)
    {
        var newTestNode = new PlatformTestNode
        {
            Uid = testNode.Uid,
            DisplayName = testNode.DisplayName,
            TestClassType = testNode.TestClassType,
            Method = testNode.Method,
            SkipMessage = testNode.SkipMessage,
            Args = testNode.Args,
            TestMethodProperty = testNode.TestMethodProperty,
            TestFileProperty = testNode.TestFileProperty
        };

        newTestNode.Properties.Add(new FailedTestNodeStateProperty(error));
        newTestNode.Properties.Add(testNode.TestMethodProperty);
        newTestNode.Properties.Add(testNode.TestFileProperty);
        
        return newTestNode;
    }
}