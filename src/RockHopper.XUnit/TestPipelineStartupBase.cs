using Microsoft.Extensions.DependencyInjection;
using Xunit.Sdk;
using Xunit.v3;

namespace RockHopper.XUnit;

/// <summary>
/// Defines the XUnit test pipeline startup extensions allowing for registration of services.
/// </summary>
public abstract class TestPipelineStartupBase : ITestPipelineStartup
{
    /// <summary>
    /// Gets the services collection to register any test services required.
    /// </summary>
    protected IServiceCollection Services { get; } = new ServiceCollection();

    /// <summary>
    /// Handles the start test pipeline hook. <b>Remember</b> that if you override this method, call the base so the
    /// services are configured in the underlying provider.
    /// </summary>
    /// <param name="diagnosticMessageSink">Message sink</param>
    /// <returns>Task</returns>
    public virtual ValueTask StartAsync(IMessageSink diagnosticMessageSink)
    {
        ServiceProviderContext.Build(Services);
        return ValueTask.CompletedTask;
    }

    /// <summary>
    /// Handles the stop test pipeline hook.
    /// </summary>
    /// <returns>Task</returns>
    public virtual ValueTask StopAsync()
    {
        return ValueTask.CompletedTask;
    }
}