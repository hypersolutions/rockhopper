using RockHopper;

var builder = RockHopperTestApplicationBuilder
    .CreateBuilder(args)
    .AddTestingFramework<Program>();

using var testApplication = await builder.BuildAsync();
_ = await testApplication.RunAsync();