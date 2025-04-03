using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using RockHopper.Engine.TestNodes;
using RockHopper.Exceptions;
using RockHopper.Mocking;

namespace RockHopper;

/// <summary>
/// Provides test-specific data for the current test being executed.
/// </summary>
public static class TestContext
{
    private static readonly AsyncLocal<TestInfo> _testInfo = new();

    /// <summary>
    /// Gets the current test context instance.
    /// </summary>
    public static TestInfo Current
    {
        get
        {
            var currentTestInfo = _testInfo.Value;

            if (currentTestInfo is null)
                _testInfo.Value = new TestInfo();

            return _testInfo.Value!;
        }
    }
    
    internal static void VerifyAll() => Current.VerifyAllMocks();

    internal static void InitCurrent(PlatformTestNode testNode, RockHopper.Engine.ExecutionContext context)
    {
        Current.Services = context.ServiceProvider;
        Current.Output = context.TestOutput;
        Current.Configuration = context.Configuration;
        Current.CancellationToken = context.CancellationToken;
        
        if (context.ClassFixture is not null)
        {
            Current.AddFixture(context.ClassFixture);
        }
        
        var fixtureAttribute = testNode.TestClassType.GetCustomAttribute<FixtureAttribute>();

        if (fixtureAttribute?.Shared is not null)
        {
            Current.AddFixture(context.GetSharedFixture(fixtureAttribute.Shared));
        }

        foreach (var assemblyFixture in context.AssemblyFixtures)
        {
            Current.AddFixture(assemblyFixture);
        }
    }
    
    /// <summary>
    /// Test context details.
    /// </summary>
    public sealed class TestInfo
    {
        private List<IFixture>? _fixtures;
        private List<Mock>? _mocks;

        internal TestInfo()
        {
        }
        
        /// <summary>
        /// Gets the test output.
        /// </summary>
        public ITestOutput Output { get; set; } = null!;

        /// <summary>
        /// Gets the test cancellation token.
        /// </summary>
        public CancellationToken CancellationToken { get; set; } = CancellationToken.None;

        internal ITestConfiguration Configuration { get; set; } = null!;
        
        internal IServiceProvider Services { get; set; } = null!;
        
        /// <summary>
        /// Gets a required service from the registered services.
        /// </summary>
        /// <typeparam name="TService">Service to get</typeparam>
        /// <returns>Service instance</returns>
        public TService GetService<TService>() where TService : notnull => Services.GetRequiredService<TService>();

        /// <summary>
        /// Gets a config value from the test config file.
        /// </summary>
        /// <param name="key">Key of config value such as Abc:Xyz - match JSON path</param>
        /// <typeparam name="TConfigValue">Value for key</typeparam>
        /// <returns>Config value</returns>
        public TConfigValue? GetConfig<TConfigValue>(string key) => Configuration.Get<TConfigValue>(key);
        
        /// <summary>
        /// Gets the test subject with the dependencies mocked.
        /// </summary>
        /// <typeparam name="TSubject">Test subject to create</typeparam>
        /// <returns>Created test subject with mock dependencies</returns>
        /// <exception cref="TestException">Failed to create the test subject</exception>
        public TSubject Subject<TSubject>()
        {
            var subjectType = typeof(TSubject);
            var ctor = subjectType.GetConstructors().First();
            _mocks ??= [];

            foreach (var parameter in ctor.GetParameters())
            {
                var mockType = typeof(Mock<>).MakeGenericType(parameter.ParameterType);
                var mock = (Mock)Activator.CreateInstance(mockType)!;
                _mocks.Add(mock);
            }

            var args = _mocks.Select(m => m.GetInstance()).ToArray();
            return (TSubject)Activator.CreateInstance(subjectType, args)!
                   ?? throw new TestException($"Unable to create an instance of the subject of type {subjectType}.");
        }
    
        /// <summary>
        /// Gets a mock for the created test subject.
        /// </summary>
        /// <typeparam name="TMock">Mock type</typeparam>
        /// <returns>Mock injected into test service</returns>
        /// <exception cref="TestException">Failed to find mock</exception>
        public Mock<TMock> Mock<TMock>() where TMock : class
        {
            var mock = _mocks?.FirstOrDefault(m => m.GetInstance() is TMock) 
                       ?? throw new TestException($"Unable to find a mock for {typeof(TMock)}.");

            return (Mock<TMock>)mock;
        }

        /// <summary>
        /// Gets a class, shared or assembly fixture.
        /// </summary>
        /// <typeparam name="TFixture">Test fixture</typeparam>
        /// <returns></returns>
        /// <exception cref="TestException">Failed to get the fixture</exception>
        public TFixture Fixture<TFixture>() where TFixture : IFixture
        {
            var fixture = _fixtures?.FirstOrDefault(f => f is TFixture) 
                          ?? throw new TestException($"Unable to find a fixture for {typeof(TFixture)}.");

            return (TFixture)fixture;
        }

        internal void VerifyAllMocks() => _mocks?.ForEach(m => m.VerifyAll());

        internal void AddFixture(IFixture fixture)
        {
            _fixtures ??= [];
            _fixtures.Add(fixture);
        }
    }
}