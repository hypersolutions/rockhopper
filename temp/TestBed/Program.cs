using RockHopper;
using TestBed;

var builder = RockHopperTestApplicationBuilder
    .CreateBuilder(args)
    .AddTestingFramework(typeof(Program).Assembly)
    .AddClassFixture<TestClassFixture>()
    .AddSharedFixture<TestSharedFixture>()
    .AddAssemblyFixture<TestAssemblyFixture>()
    .AddSingleton<IAssemblySetup, AssemblySetup>()
    .AddTransient<ITestSetup, TestSetup>()
    .AddSingleton<IPreTestHook, PreTestHook>()
    .AddSingleton<IPostTestHook, PostTestHook>();

using var testApplication = await builder.BuildAsync();
Environment.ExitCode = await testApplication.RunAsync();