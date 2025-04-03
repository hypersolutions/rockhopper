using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Testing.Extensions;
using Microsoft.Testing.Platform.Builder;
using Microsoft.Testing.Platform.Capabilities.TestFramework;
using Microsoft.Testing.Platform.CommandLine;
using Microsoft.Testing.Platform.Configurations;
using Microsoft.Testing.Platform.Extensions.TestFramework;
using Microsoft.Testing.Platform.Logging;
using Microsoft.Testing.Platform.Services;
using Microsoft.Testing.Platform.TestHost;
using Microsoft.Testing.Platform.TestHostControllers;
using RockHopper.Engine;
using RockHopper.Engine.Capabilities;
using RockHopper.Engine.Options;

#pragma warning disable TPEXP

namespace RockHopper;

public sealed class RockHopperTestApplicationBuilder : IRockHopperTestApplicationBuilder
{
    private readonly ITestApplicationBuilder _builder;
    private readonly TestExtension _extension;

    private RockHopperTestApplicationBuilder(ITestApplicationBuilder builder)
    {
        _builder = builder;
        _extension = new TestExtension();
    }

    public IServiceCollection Services { get; } = new ServiceCollection();
    
    public ITestHostManager TestHost => _builder.TestHost;
    
    public ITestHostControllersManager TestHostControllers => _builder.TestHostControllers;
    
    public ICommandLineManager CommandLine => _builder.CommandLine;
    
    public IConfigurationManager Configuration => _builder.Configuration;
    
    public ILoggingManager Logging => _builder.Logging;
    
    public static IRockHopperTestApplicationBuilder CreateBuilder(string[] args, TestApplicationOptions? options = null)
    {
        var builder = Task.Run(async () => await TestApplication.CreateBuilderAsync(args, options));
        return new RockHopperTestApplicationBuilder(builder.Result);
    }
    
    public ITestApplicationBuilder RegisterTestFramework(
        Func<IServiceProvider, ITestFrameworkCapabilities> capabilitiesFactory, 
        Func<ITestFrameworkCapabilities, IServiceProvider, ITestFramework> adapterFactory)
    {
        _builder.RegisterTestFramework(capabilitiesFactory, adapterFactory);
        _builder.CommandLine.AddProvider(() => new ParallelTestCommandProvider(_extension));
        _builder.AddTrxReportProvider();
        return this;
    }

    public Task<ITestApplication> BuildAsync()
    {
        return _builder.BuildAsync();
    }
    
    public IRockHopperTestApplicationBuilder AddTestingFramework<TProject>()
    {
        RegisterTestFrameworkForAssemblies(typeof(TProject).Assembly);
        return this;
    }
    
    public IRockHopperTestApplicationBuilder AddTestingFramework(params Assembly[] assemblies)
    {
        RegisterTestFrameworkForAssemblies(assemblies);
        return this;
    }

    public IRockHopperTestApplicationBuilder AddClassFixture<TFixture>() where TFixture : class, IClassFixture
    {
        Services.AddKeyedTransient<IClassFixture, TFixture>(typeof(TFixture).FullName);
        return this;
    }
    
    public IRockHopperTestApplicationBuilder AddSharedFixture<TFixture>() where TFixture : class, ISharedFixture
    {
        Services.AddKeyedSingleton<ISharedFixture, TFixture>(typeof(TFixture).FullName);
        return this;
    }
    
    public IRockHopperTestApplicationBuilder AddAssemblyFixture<TFixture>() where TFixture : class, IAssemblyFixture
    {
        Services.AddSingleton<IAssemblyFixture, TFixture>();
        return this;
    }

    public IRockHopperTestApplicationBuilder AddSingleton<TService, TImplementation>()
        where TService : class
        where TImplementation : class, TService
    {
        Services.AddSingleton<TService, TImplementation>();
        return this;
    }
    
    public IRockHopperTestApplicationBuilder AddTransient<TService, TImplementation>()
        where TService : class
        where TImplementation : class, TService
    {
        Services.AddTransient<TService, TImplementation>();
        return this;
    }
    
    private void RegisterTestFrameworkForAssemblies(params Assembly[] assemblies)
    {
        RegisterTestFramework(
            serviceProvider  => new TestFrameworkCapabilities(
                new TrxReportCapability(), 
                new BannerCapability(ServiceProviderExtensions.GetRequiredService<IPlatformInformation>(serviceProvider))),
            (_, serviceProvider) => new TestingFramework(_extension, serviceProvider, Services.BuildServiceProvider(), assemblies));
        
        //TestHost.AddTestApplicationLifecycleCallbacks(serviceProvider
        //    => new DisplayTestApplicationLifecycleCallbacks(serviceProvider.GetOutputDevice()));
    }
}