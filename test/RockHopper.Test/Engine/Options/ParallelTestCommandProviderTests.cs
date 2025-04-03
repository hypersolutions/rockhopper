using Microsoft.Testing.Platform.Extensions;
using Microsoft.Testing.Platform.Extensions.CommandLine;
using RockHopper.Assertions;
using RockHopper.Engine.Options;
using RockHopper.Mocking;

namespace RockHopper.Test.Engine.Options;

public class ParallelTestCommandProviderTests
{
    private readonly ParallelTestCommandProvider _provider = TestContext.Subject<ParallelTestCommandProvider>();
    private readonly Mock<IExtension> _extension = TestContext.Mock<IExtension>();

    [Test]
    public void FromExtension_Uid_ReturnsValue()
    {
        _extension.Setup(e => e.Uid).Returns("TestId");
        
        _provider.Uid.ShouldBe("TestId");
    }
    
    [Test]
    public void FromExtension_Version_ReturnsValue()
    {
        _extension.Setup(e => e.Version).Returns("1.2.3");
        
        _provider.Version.ShouldBe("1.2.3");
    }
    
    [Test]
    public void FromExtension_DisplayName_ReturnsValue()
    {
        _extension.Setup(e => e.DisplayName).Returns("Test Extension");
        
        _provider.DisplayName.ShouldBe("Test Extension");
    }
    
    [Test]
    public void FromExtension_Description_ReturnsValue()
    {
        _extension.Setup(e => e.Description).Returns("Test extension");
        
        _provider.Description.ShouldBe("Test extension");
    }
    
    [Test]
    public async Task FromExtension_IsEnabledAsync_ReturnsValue()
    {
        _extension.Setup(e => e.IsEnabledAsync()).ReturnsAsync(true);

        var enabled = await _provider.IsEnabledAsync();
        
        enabled.ShouldBeTrue();
    }
    
    [Test]
    public void ConfiguredOption_GetCommandLineOptions_ReturnsSingleDefinition()
    {
        var options = _provider.GetCommandLineOptions();
        
        options.ShouldBeSingle();
        var option = options.First();
        option.Name.ShouldBe("max-parallel-tests");
        option.Description.ShouldBe("Maximum number of tests to run in parallel 1 to 10 inclusive.");
        option.Arity.ShouldBe(ArgumentArity.ExactlyOne);
        option.IsHidden.ShouldBeFalse();
    }

    [Test]
    public async Task InvalidArgLength_ValidateOptionArgumentsAsync_ReturnsInvalidTask()
    {
        var option = _provider.GetCommandLineOptions().First();

        var result = await _provider.ValidateOptionArgumentsAsync(option, ["1", "2"]);
        
        result.IsValid.ShouldBeFalse();
        result.ErrorMessage.ShouldBe("Only one value is required for the maximum parallel tests.");
    }
    
    [Test]
    public async Task NegativeNumber_ValidateOptionArgumentsAsync_ReturnsInvalidTask()
    {
        var option = _provider.GetCommandLineOptions().First();

        var result = await _provider.ValidateOptionArgumentsAsync(option, ["-1"]);
        
        result.IsValid.ShouldBeFalse();
        result.ErrorMessage.ShouldBe("The maximum parallel tests value must be a positive integer.");
    }
    
    [Test]
    public async Task NumberGreaterThanMax_ValidateOptionArgumentsAsync_ReturnsInvalidTask()
    {
        var option = _provider.GetCommandLineOptions().First();

        var result = await _provider.ValidateOptionArgumentsAsync(option, ["11"]);
        
        result.IsValid.ShouldBeFalse();
        result.ErrorMessage.ShouldBe("The maximum parallel tests value must be between 1 and 10.");
    }
    
    [Test(InlineArgs = [1])]
    [Test(InlineArgs = [2])]
    [Test(InlineArgs = [3])]
    [Test(InlineArgs = [4])]
    [Test(InlineArgs = [5])]
    [Test(InlineArgs = [6])]
    [Test(InlineArgs = [7])]
    [Test(InlineArgs = [8])]
    [Test(InlineArgs = [9])]
    [Test(InlineArgs = [10])]
    public async Task ValidNumber_ValidateOptionArgumentsAsync_ReturnsValidTask(int parallel)
    {
        var option = _provider.GetCommandLineOptions().First();

        var result = await _provider.ValidateOptionArgumentsAsync(option, [parallel.ToString()]);
        
        result.IsValid.ShouldBeTrue();
        result.ErrorMessage.ShouldBeNull();
    }
}