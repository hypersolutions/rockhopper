using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace RockHopper.NUnit;

[SetUpFixture]
public abstract class TestPipelineStartupBase
{
    /// <summary>
    /// Gets the services collection to register any test services required.
    /// </summary>
    protected IServiceCollection Services { get; } = new ServiceCollection();
    
    /// <summary>
    /// Handles the start test pipeline hook. <b>Remember</b> that if you override this method, call the base so the
    /// services are configured in the underlying provider.
    /// </summary>
    [OneTimeSetUp]
    public virtual void Start()
    {
        ServiceProviderContext.Build(Services);
    }

    /// <summary>
    /// Handles the stop test pipeline hook.
    /// </summary>
    [OneTimeTearDown]
    public virtual void Stop()
    {
    }
}