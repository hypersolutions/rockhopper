using Microsoft.Extensions.DependencyInjection;
using RockHopper.Exceptions;
using RockHopper.Mocking;

namespace RockHopper;

/// <summary>
/// Provides test-specific data for the current test being executed.
/// </summary>
public static class TestContext
{
    private static readonly AsyncLocal<TestInfo> _testInfo = new();

    private static TestInfo Current
    {
        get
        {
            var currentTestInfo = _testInfo.Value;

            if (currentTestInfo is null)
                _testInfo.Value = new TestInfo();

            return _testInfo.Value!;
        }
    }

    /// <summary>
    /// Provides a output to log messages to.
    /// </summary>
    public static ITestOutput TestOutput => Current.TestOutputPipe;

    /// <summary>
    /// Provides access to configuration.
    /// </summary>
    public static ITestConfiguration Configuration => Current.TestConfiguration;

    /// <summary>
    /// Gets the cancellation token for the test.
    /// </summary>
    public static CancellationToken CancellationToken => Current.TestCancellationToken;
    
    /// <summary>
    /// Get the subject constructed by the test framework.
    /// </summary>
    /// <typeparam name="TSubject">Subject type</typeparam>
    /// <returns>Created subject with dependencies mocked</returns>
    public static TSubject Subject<TSubject>() => Current.CreateSubject<TSubject>();

    /// <summary>
    /// Gets a mock that was injected into the subject upon creation.
    /// </summary>
    /// <typeparam name="TMock">Mock type</typeparam>
    /// <returns>Mock instance</returns>
    public static Mock<TMock> Mock<TMock>() where TMock : class => Current.GetMock<TMock>();
    
    /// <summary>
    /// Gets a class or shared fixture.
    /// </summary>
    /// <typeparam name="TFixture">Fixture type</typeparam>
    /// <returns>Fixture instance</returns>
    public static TFixture Fixture<TFixture>() where TFixture : class => Current.GetFixture<TFixture>();

    /// <summary>
    /// Gets a registered service to be used in a test.
    /// </summary>
    /// <typeparam name="TService">Service to get</typeparam>
    /// <returns>Service instance or throws exception if not found</returns>
    public static TService Service<TService>() where TService : class => Current.TestServiceProvider.GetRequiredService<TService>();
    
    internal static void VerifyAll() => Current.VerifyAllMocks();

    internal static void AddFixture(IClassFixture fixture) => Current.AddClassFixture(fixture);
    
    internal static void AddFixture(ISharedFixture fixture) => Current.AddSharedFixture(fixture);
    
    internal static void AddFixture(IAssemblyFixture fixture) => Current.AddAssemblyFixture(fixture);

    internal static void InitCurrent(
        IServiceProvider serviceProvider, 
        ITestOutput testOutput, 
        ITestConfiguration configuration,
        CancellationToken cancellationToken)
    {
        Current.TestServiceProvider = serviceProvider;
        Current.TestOutputPipe = testOutput;
        Current.TestConfiguration = configuration;
        Current.TestCancellationToken = cancellationToken;
    }
    
    private sealed class TestInfo
    {
        private readonly List<Mock> _mocks = [];
        private readonly List<object> _fixtures = [];

        public ITestOutput TestOutputPipe { get; set; } = null!;

        public ITestConfiguration TestConfiguration { get; set; } = null!;
        
        public IServiceProvider TestServiceProvider { get; set; } = null!;

        public CancellationToken TestCancellationToken { get; set; } = CancellationToken.None;
        
        public TSubject CreateSubject<TSubject>()
        {
            var subjectType = typeof(TSubject);
            var ctor = subjectType.GetConstructors().First();

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
    
        public Mock<TMock> GetMock<TMock>() where TMock : class
        {
            var mock = _mocks.FirstOrDefault(m => m.GetInstance() is TMock) 
                       ?? throw new TestException($"Unable to find a mock for {typeof(TMock)}.");

            return (Mock<TMock>)mock;
        }

        public TFixture GetFixture<TFixture>() where TFixture : class
        {
            var fixture = _fixtures.FirstOrDefault(f => f is TFixture) 
                          ?? throw new TestException($"Unable to find a fixture for {typeof(TFixture)}.");

            return (TFixture)fixture;
        }

        public void VerifyAllMocks() => _mocks.ForEach(m => m.VerifyAll());

        public void AddClassFixture(IClassFixture fixture)
        {
            _fixtures.Add(fixture);
        }
        
        public void AddSharedFixture(ISharedFixture fixture)
        {
            _fixtures.Add(fixture);
        }
        
        public void AddAssemblyFixture(IAssemblyFixture fixture)
        {
            _fixtures.Add(fixture);
        }
    }
}