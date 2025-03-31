using Microsoft.Testing.Platform.Extensions;

namespace RockHopper.Engine;

internal sealed class TestExtension : IExtension
{
    public Task<bool> IsEnabledAsync()
    {
        return Task.FromResult(true);
    }

    public string Uid => "RockHopper";
    
    public string Version => "1.0.0";
    
    public string DisplayName => "RockHopper";
    
    public string Description => "RockHopper unit test, mocking and assertion framework.";
}