using RockHopper;
using RockHopper.IntTest.Support;

var builder = RockHopperTestApplicationBuilder
    .CreateBuilder(args)
    .AddTestingFramework<Program>()
    .AddClassFixture<TwoNumbersClassFixture>()
    .AddSharedFixture<TwoNumbersSharedFixture>()
    .AddAssemblyFixture<TwoNumbersAssemblyFixture>();

using var testApplication = await builder.BuildAsync();
Environment.ExitCode = await testApplication.RunAsync();