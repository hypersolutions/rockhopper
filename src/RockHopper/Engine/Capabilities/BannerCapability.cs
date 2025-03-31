using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Testing.Platform.Capabilities.TestFramework;
using Microsoft.Testing.Platform.Services;
#pragma warning disable TPEXP

namespace RockHopper.Engine.Capabilities;

internal class BannerCapability : IBannerMessageOwnerCapability
{
    private readonly IPlatformInformation _platformInformation;
    
    public BannerCapability(IPlatformInformation platformInformation)
    {
        _platformInformation = platformInformation;
    }
    
    public Task<string?> GetBannerMessageAsync()
    {
        List<string> info =
        [
            Environment.Is64BitProcess ? "64-bit" : "32-bit",
            RuntimeInformation.OSDescription,
#if NET
            RuntimeInformation.RuntimeIdentifier,
#else 
            ".NET Framework",
#endif
            RuntimeInformation.FrameworkDescription,
            $"Microsoft Testing Platform v{_platformInformation.Version}"
        ];

        var message = new StringBuilder();
        message.AppendLine();
        message.AppendLine("RockHopper v1.0.0 - the friendly test framework");
        message.AppendLine();
        message.AppendLine(string.Join(" | ", info));
        return Task.FromResult<string?>(message.ToString());
    }
}