using Microsoft.Extensions.DependencyInjection;

namespace RockHopper.XUnit;

internal static class ServiceProviderContext
{
    internal static IServiceProvider Provider { get; private set; } = null!;
    
    internal static void Build(IServiceCollection services)
    {
        Provider = services.BuildServiceProvider();
    }
}