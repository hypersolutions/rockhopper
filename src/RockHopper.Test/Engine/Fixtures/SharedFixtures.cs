using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using RockHopper.Test.Engine.TestNodes;
using RockHopper.Test.Exceptions;
using RockHopper.Test.Extensions;

namespace RockHopper.Test.Engine.Fixtures;

internal static class SharedFixtures
{
    internal static async Task<IList<SharedFixtureInfo>> BuildAsync(IList<PlatformTestNode> testNodes, IServiceProvider provider)
    {
        var sharedFixtureInfoList = new List<SharedFixtureInfo>();
        
        foreach (var testNode in testNodes)
        {
            var fixtureAttribute = testNode.TestClassType.GetCustomAttribute<FixtureAttribute>();

            if (fixtureAttribute?.Shared is null) continue;
                        
            var sharedFixture = sharedFixtureInfoList.FirstOrDefault(l => l.ContainsFixtureType(fixtureAttribute.Shared));
                        
            if (sharedFixture is null)
            {
                var fixture = provider.GetKeyedService<ISharedFixture>(fixtureAttribute.Shared.FullName);

                if (fixture is null)
                {
                    throw new TestException($"Unable to find shared fixture {fixtureAttribute.Shared.FullName}. Have you registered it?");
                }

                await fixture.ExecuteAsync();
                
                sharedFixture = new SharedFixtureInfo(fixture);
                sharedFixtureInfoList.Add(sharedFixture);
            }
                            
            var sharedFixtureInfo = sharedFixtureInfoList.FirstOrDefault(l => l.ContainsTestClassType(testNode.TestClassType));

            if (sharedFixtureInfo is null)
            {
                sharedFixture.AddType(testNode.TestClassType);
            }
        }

        return sharedFixtureInfoList;
    }

    internal static IList<ISharedFixture> Filter(IList<SharedFixtureInfo> sharedFixtureInfoList, Type testClassType)
    {
        return sharedFixtureInfoList.Where(l => l.ContainsTestClassType(testClassType)).Select(l => l.Fixture).ToList();
    }
    
    internal static async Task DisposeAsync(IList<SharedFixtureInfo> sharedFixtureInfoList)
    {
        foreach (var sharedFixtureInfo in sharedFixtureInfoList)
        {
            await sharedFixtureInfo.Dispose();
        }
    }
}