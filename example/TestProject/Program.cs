using RockHopper.Test;

var builder = RockHopperTestApplicationBuilder
    .CreateBuilder(args)
    .AddTestingFramework<Program>();

using var testApplication = await builder.BuildAsync();
Environment.ExitCode = await testApplication.RunAsync();