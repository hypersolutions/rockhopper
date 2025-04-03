using Microsoft.Testing.Platform.CommandLine;
using Microsoft.Testing.Platform.Extensions;
using Microsoft.Testing.Platform.Extensions.CommandLine;

namespace RockHopper.Engine.Options;

internal sealed class ParallelTestCommandProvider : ICommandLineOptionsProvider
{
    private readonly IExtension _extension;
    public const string MaxParallelTests = "max-parallel-tests";
    
    public ParallelTestCommandProvider(IExtension extension)
    {
        _extension = extension;
    }

    public string Uid => _extension.Uid;

    public string Version => _extension.Version;

    public string DisplayName => _extension.DisplayName;

    public string Description => _extension.Description;
    
    public Task<bool> IsEnabledAsync()
    {
        return _extension.IsEnabledAsync();
    }
    
    public IReadOnlyCollection<CommandLineOption> GetCommandLineOptions()
    {
        return
        [
            new CommandLineOption(
                MaxParallelTests, 
                "Maximum number of tests to run in parallel 1 to 10 inclusive.",
                ArgumentArity.ExactlyOne,
                false)
        ];
    }

    public Task<ValidationResult> ValidateOptionArgumentsAsync(CommandLineOption commandOption, string[] arguments)
    {
        if (commandOption.Name == MaxParallelTests && arguments.Length != 1)
        {
            return ValidationResult.InvalidTask("Only one value is required for the maximum parallel tests.");
        }
        
        if (commandOption.Name == MaxParallelTests)
        {
            if (!int.TryParse(arguments[0], out var maxParallelTests) || maxParallelTests < 1)
            {
                return ValidationResult.InvalidTask("The maximum parallel tests value must be a positive integer.");
            }

            if (maxParallelTests > 10)
            {
                return ValidationResult.InvalidTask("The maximum parallel tests value must be between 1 and 10.");
            }
        }
        
        return ValidationResult.ValidTask;
    }

    public Task<ValidationResult> ValidateCommandLineOptionsAsync(ICommandLineOptions commandLineOptions)
    {
        return ValidationResult.ValidTask; // TODO: Do we need to implement this?
    }
}