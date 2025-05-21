using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Testing.Platform.Builder;

// ReSharper disable UnusedMethodReturnValue.Global - Builder pattern

#pragma warning disable TPEXP

namespace RockHopper.Test;

/// <summary>
/// Defines the members of the extended ITestApplicationBuilder interface.
/// </summary>
public interface IRockHopperTestApplicationBuilder : ITestApplicationBuilder
{
    /// <summary>
    /// Gets the service collection for registering services used throughout tests.
    /// </summary>
    IServiceCollection Services { get; }

    /// <summary>
    /// Adds the test framework for a specific project.
    /// </summary>
    /// <typeparam name="TProject">Project containing tests</typeparam>
    /// <returns>Builder</returns>
    IRockHopperTestApplicationBuilder AddTestingFramework<TProject>();
    
    /// <summary>
    /// Adds the test framework for a list of assemblies.
    /// </summary>
    /// <param name="assemblies">List of assemblies with tests</param>
    /// <returns>Builder</returns>
    IRockHopperTestApplicationBuilder AddTestingFramework(params Assembly[] assemblies);

    /// <summary>
    /// Adds a class fixture.
    /// </summary>
    /// <typeparam name="TFixture">Fixture type</typeparam>
    /// <returns>Builder</returns>
    IRockHopperTestApplicationBuilder AddClassFixture<TFixture>() where TFixture : class, IClassFixture;

    /// <summary>
    /// Adds a shared fixture.
    /// </summary>
    /// <typeparam name="TFixture">Fixture type</typeparam>
    /// <returns>Builder</returns>
    IRockHopperTestApplicationBuilder AddSharedFixture<TFixture>() where TFixture : class, ISharedFixture;

    /// <summary>
    /// Adds a assembly fixture.
    /// </summary>
    /// <typeparam name="TFixture">Fixture type</typeparam>
    /// <returns>Builder</returns>
    IRockHopperTestApplicationBuilder AddAssemblyFixture<TFixture>() where TFixture : class, IAssemblyFixture;

    /// <summary>
    /// Registers a singleton service.
    /// </summary>
    /// <typeparam name="TService">Service contract</typeparam>
    /// <typeparam name="TImplementation">Service implementation</typeparam>
    /// <returns>Builder</returns>
    IRockHopperTestApplicationBuilder AddSingleton<TService, TImplementation>() 
        where TService : class 
        where TImplementation : class, TService;
    
    /// <summary>
    /// Registers a singleton service.
    /// </summary>
    /// <typeparam name="TService">Service contract</typeparam>
    /// <typeparam name="TImplementation">Service implementation</typeparam>
    /// <returns>Builder</returns>
    IRockHopperTestApplicationBuilder AddTransient<TService, TImplementation>() 
        where TService : class 
        where TImplementation : class, TService;
}