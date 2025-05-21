using RockHopper.Test.Exceptions;

namespace RockHopper.Test.Engine;

internal sealed class ExecutionContext
{
    internal ExecutionContext(
        IClassFixture? classFixture, 
        IList<ISharedFixture> sharedFixtures, 
        IList<IAssemblyFixture> assemblyFixtures, 
        ITestOutput testOutput,
        ITestConfiguration configuration,
        IServiceProvider serviceProvider,
        CancellationToken cancellationToken)
    {
        ClassFixture = classFixture;
        SharedFixtures = sharedFixtures;
        AssemblyFixtures = assemblyFixtures;
        TestOutput = testOutput;
        Configuration = configuration;
        ServiceProvider = serviceProvider;
        CancellationToken = cancellationToken;
    }
    
    internal IClassFixture? ClassFixture { get; }
    
    internal IList<ISharedFixture> SharedFixtures { get; }
    
    internal IList<IAssemblyFixture> AssemblyFixtures { get; }

    internal ITestOutput TestOutput { get; }

    internal ITestConfiguration Configuration { get; }
    
    internal IServiceProvider ServiceProvider { get; }

    internal CancellationToken CancellationToken { get; }

    internal ISharedFixture GetSharedFixture(Type fixtureType)
    {
        return SharedFixtures.FirstOrDefault(a => a.GetType() == fixtureType) 
               ?? throw new TestException($"Unable to find a fixture for {fixtureType}.");
    }
}