using Microsoft.Extensions.DependencyInjection;
using RockHopper.Test.Exceptions;

namespace RockHopper.Test.Engine.Fixtures;

internal static class ClassFixtures
{
    internal static async Task<IClassFixture?> BuildAsync(IServiceProvider provider, Type? classFixtureType)
    {
        if (classFixtureType is null)
            return null;
        
        var classFixture = provider.GetKeyedService<IClassFixture>(classFixtureType.FullName);
                            
        if (classFixture is null)
            throw new TestException($"The class fixture type {classFixtureType} has not been registered or is the incorrect type.");

        await classFixture.ExecuteAsync();

        return classFixture;
    }
}