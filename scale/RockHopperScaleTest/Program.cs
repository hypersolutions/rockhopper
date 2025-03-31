using RockHopper;

var builder = RockHopperTestApplicationBuilder
    .CreateBuilder(args)
    .AddTestingFramework(typeof(Program).Assembly);

using var testApplication = await builder.BuildAsync();
_ = await testApplication.RunAsync();