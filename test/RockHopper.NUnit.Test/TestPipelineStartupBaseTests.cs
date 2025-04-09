using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using RockHopper.Assertions;

// ReSharper disable MemberCanBePrivate.Global - Test support

namespace RockHopper.NUnit.Test;

public class TestPipelineStartupBaseTests
{
    [Test]
    public void UnregisteredService_GetService_ReturnsNull()
    {
        var testService = TestContext.CurrentContext.GetService<INotImplementedTestService>();
        
        testService.ShouldBeNull();
    }
    
    [Test]
    public void RegisteredService_GetService_ReturnsService()
    {
        var testService = TestContext.CurrentContext.GetService<ITestService>();
        
        testService.ShouldNotBeNull();
    }
    
    [Test]
    public void UnregisteredService_GetRequiredService_ThrowsException()
    {
        Should.Throw<InvalidOperationException>(
            () => TestContext.CurrentContext.GetRequiredService<INotImplementedTestService>());
    }
    
    [Test]
    public void RegisteredService_GetRequiredService_ReturnsService()
    {
        var testService = TestContext.CurrentContext.GetRequiredService<ITestService>();
        
        testService.ShouldNotBeNull();
    }
    
    [Test]
    public void UnregisteredServices_GetServices_ReturnsEmptyList()
    {
        var services = TestContext.CurrentContext.GetServices<INotImplementedTestService>().ToList();
        
        services.ShouldBeEmpty();
    }
    
    [Test]
    public void RegisteredServices_GetServices_ReturnsServices()
    {
        var services = TestContext.CurrentContext.GetServices<TestBase>().ToList();
        
        services.ShouldContainCount(2);
        services[0].ShouldBeOfType<TestBase1>();
        services[1].ShouldBeOfType<TestBase2>();
    }
    
    public sealed class ExampleTestPipelineStartup : TestPipelineStartupBase
    {
        public override void Start()
        {
            Services.AddSingleton<ITestService, TestService>();
            Services.AddTransient<TestBase, TestBase1>();
            Services.AddTransient<TestBase, TestBase2>();
            base.Start();
        }
    }

    public interface ITestService;

    public sealed class TestService : ITestService;
    
    public interface INotImplementedTestService;

    public abstract class TestBase;

    public sealed class TestBase1 : TestBase;
    
    public sealed class TestBase2 : TestBase;
}