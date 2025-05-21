using Microsoft.Testing.Extensions.TrxReport.Abstractions;

namespace RockHopper.Test.Engine.Capabilities;

internal class TrxReportCapability : ITrxReportCapability
{
    public bool IsSupported => true;
    
    public void Enable()
    {
    }
}