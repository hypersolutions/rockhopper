using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using RockHopper.Exceptions;
using RockHopper.Mocking;
// ReSharper disable UnusedParameter.Global - Contract

namespace RockHopper.NUnit;

/// <summary>
/// Extends the <i>Nunit.Framework.TestContext</i> to add support for class under test creation.
/// </summary>
public static class NUnitTestContextExtensions
{
    private static readonly AsyncLocal<SubjectInfo> _testInfo = new();
    
    /// <summary>
    /// Creates a subject and any mocks for a test. If called multiple times during the test, the same subject instance
    /// will be returned.
    /// </summary>
    /// <param name="context">Extended NUnit context</param>
    /// <typeparam name="TSubject">Class under test to create</typeparam>
    /// <returns>Created instance of class under test</returns>
    public static TSubject CreateSubject<TSubject>(this TestContext context)
    {
        _testInfo.Value ??= new SubjectInfo();

        return _testInfo.Value.GetSubject<TSubject>(SubjectBuilderFlags.Constructor, new DefaultConstructorSelector());
    }
    
    /// <summary>
    /// Gets a mock that was injected into the created class under test. <b>Important</b> that you call CreateSubject first.
    /// </summary>
    /// <param name="context">Extended NUnit context</param>
    /// <typeparam name="TMock">Mock to get that was injected into the class under test</typeparam>
    /// <returns>Created mock</returns>
    /// <exception cref="TestException">If the class under test has not been created or the mock cannot be found</exception>
    public static Mock<TMock> GetMock<TMock>(this TestContext context) where TMock : class
    {
        if (_testInfo.Value is null)
        {
            throw new TestException("No test mocks exist. You need to call the CreateSubject first.");
        }

        return _testInfo.Value.GetMock<TMock>();
    }

    /// <summary>
    /// This will verify all the mocks that have been created for the class under test.
    /// </summary>
    /// <param name="context">Extended NUnit context</param>
    public static void VerifyAll(this TestContext context)
    {
        _testInfo.Value?.VerifyAllMocks();
    }

    /// <summary>
    /// Gets a service registered with the service provider.
    /// </summary>
    /// <param name="context">Extended NUnit context</param>
    /// <typeparam name="TService">Service to get</typeparam>
    /// <returns>Service instance if found else null</returns>
    public static TService? GetService<TService>(this TestContext context)
    {
        return ServiceProviderContext.Provider.GetService<TService>();
    }
    
    /// <summary>
    /// Gets a list of services registered with the service provider.
    /// </summary>
    /// <param name="context">Extended XUnit context</param>
    /// <typeparam name="TService">Service to get</typeparam>
    /// <returns>Service instance list</returns>
    public static IEnumerable<TService> GetServices<TService>(this TestContext context)
    {
        return ServiceProviderContext.Provider.GetServices<TService>();
    }
    
    /// <summary>
    /// Gets a required service registered with the service provider.
    /// </summary>
    /// <param name="context">Extended XUnit context</param>
    /// <typeparam name="TService">Service to get</typeparam>
    /// <returns>Service instance else throws an exception</returns>
    public static TService GetRequiredService<TService>(this TestContext context) where TService : notnull
    {
        return ServiceProviderContext.Provider.GetRequiredService<TService>();
    }
}