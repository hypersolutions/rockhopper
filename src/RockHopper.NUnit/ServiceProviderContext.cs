using Microsoft.Extensions.DependencyInjection;

namespace RockHopper.NUnit;

internal static class ServiceProviderContext
{
    static ServiceProviderContext()
    {
        var services = new ServiceCollection();
        Provider = services.BuildServiceProvider();
    }
    
    internal static IServiceProvider Provider { get; private set; }
    
    internal static void Build(IServiceCollection services)
    {
        Provider = services.BuildServiceProvider();
    }
}