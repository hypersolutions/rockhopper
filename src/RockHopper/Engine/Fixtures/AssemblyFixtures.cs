using Microsoft.Extensions.DependencyInjection;
using RockHopper.Extensions;

namespace RockHopper.Engine.Fixtures;

internal static class AssemblyFixtures
{
    internal static async Task<IList<IAssemblyFixture>> BuildAsync(IServiceProvider provider)
    {
        var assemblyFixtures = provider.GetServices<IAssemblyFixture>().ToList();

        foreach (var assemblyFixture in assemblyFixtures)
        {
            await assemblyFixture.ExecuteAsync();
        }

        return assemblyFixtures;
    }

    internal static async Task DisposeAsync(IList<IAssemblyFixture> assemblyFixtureList)
    {
        foreach (var sharedFixtureInfo in assemblyFixtureList)
        {
            await sharedFixtureInfo.Dispose();
        }
    }
}