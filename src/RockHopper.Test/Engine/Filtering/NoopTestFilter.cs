using RockHopper.Test.Engine.TestNodes;

namespace RockHopper.Test.Engine.Filtering;

internal sealed class NoopTestFilter : TestFilter
{
    internal override IList<PlatformTestNode> Filter(IList<PlatformTestNode> testNodes) => testNodes;
}