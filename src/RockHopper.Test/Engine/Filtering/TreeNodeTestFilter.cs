using Microsoft.Testing.Platform.Extensions.Messages;
using Microsoft.Testing.Platform.Requests;
using RockHopper.Test.Engine.TestNodes;

#pragma warning disable TPEXP

namespace RockHopper.Test.Engine.Filtering;

internal sealed class TreeNodeTestFilter : TestFilter
{
    private readonly TreeNodeFilter _filter;

    public TreeNodeTestFilter(TreeNodeFilter filter)
    {
        _filter = filter;
    }
    
    internal override IList<PlatformTestNode> Filter(IList<PlatformTestNode> testNodes) 
        => testNodes.Where(n => _filter.MatchesFilter(n.GetFullName(), new PropertyBag())).ToList();
}