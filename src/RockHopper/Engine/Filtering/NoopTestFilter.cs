using RockHopper.Engine.TestNodes;

namespace RockHopper.Engine.Filtering;

internal sealed class NoopTestFilter : TestFilter
{
    internal override IList<PlatformTestNode> Filter(IList<PlatformTestNode> testNodes) => testNodes;
}