using Microsoft.Testing.Platform.Extensions.TestFramework;
using Microsoft.Testing.Platform.Requests;
using RockHopper.Test.Engine.TestNodes;

#pragma warning disable TPEXP

namespace RockHopper.Test.Engine.Filtering;

internal abstract class TestFilter
{
    internal abstract IList<PlatformTestNode> Filter(IList<PlatformTestNode> testNodes);
    
    internal static TestFilter GetTestFilter(ExecuteRequestContext context)
    {
        var filter = context.Request switch
        {
            RunTestExecutionRequest executionRequest => executionRequest.Filter,
            _ => new NopFilter()
        };

        return filter is TreeNodeFilter treeFilter ? new TreeNodeTestFilter(treeFilter) : new NoopTestFilter();
    }
}