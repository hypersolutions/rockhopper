using Microsoft.Extensions.DependencyInjection;
using RockHopper.Assertions;
using RockHopper.XUnit.Test;
using Xunit.Sdk;
using Xunit.v3;
// ReSharper disable MemberCanBePrivate.Global - Test support

[assembly: TestPipelineStartup(typeof(TestPipelineStartupBaseTests.ExampleTestPipelineStartup))]

namespace RockHopper.XUnit.Test;

public class TestPipelineStartupBaseTests
{
    [Fact]
    public void UnregisteredService_GetService_ReturnsNull()
    {
        var testService = TestContext.Current.GetService<INotImplementedTestService>();
        
        testService.ShouldBeNull();
    }
    
    [Fact]
    public void RegisteredService_GetService_ReturnsService()
    {
        var testService = TestContext.Current.GetService<ITestService>();
        
        testService.ShouldNotBeNull();
    }
    
    [Fact]
    public void UnregisteredService_GetRequiredService_ThrowsException()
    {
        Should.Throw<InvalidOperationException>(
            () => TestContext.Current.GetRequiredService<INotImplementedTestService>());
    }
    
    [Fact]
    public void RegisteredService_GetRequiredService_ReturnsService()
    {
        var testService = TestContext.Current.GetRequiredService<ITestService>();
        
        testService.ShouldNotBeNull();
    }
    
    [Fact]
    public void UnregisteredServices_GetServices_ReturnsEmptyList()
    {
        var services = TestContext.Current.GetServices<INotImplementedTestService>().ToList();
        
        services.ShouldBeEmpty();
    }
    
    [Fact]
    public void RegisteredServices_GetServices_ReturnsServices()
    {
        var services = TestContext.Current.GetServices<TestBase>().ToList();
        
        services.ShouldContainCount(2);
        services[0].ShouldBeOfType<TestBase1>();
        services[1].ShouldBeOfType<TestBase2>();
    }
    
    public sealed class ExampleTestPipelineStartup : TestPipelineStartupBase
    {
        public override ValueTask StartAsync(IMessageSink diagnosticMessageSink)
        {
            Services.AddSingleton<ITestService, TestService>();
            Services.AddTransient<TestBase, TestBase1>();
            Services.AddTransient<TestBase, TestBase2>();
            return base.StartAsync(diagnosticMessageSink);
        }
    }

    public interface ITestService;

    public sealed class TestService : ITestService;
    
    public interface INotImplementedTestService;

    public abstract class TestBase;

    public sealed class TestBase1 : TestBase;
    
    public sealed class TestBase2 : TestBase;
}