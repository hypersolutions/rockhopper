using System.Reflection;
using RockHopper.Mocking;

namespace RockHopper.Builder;

internal sealed class ParameterMocks : Dictionary<ParameterInfo, Mock>
{
    internal object[] GetInstances()
    {
        return this.Select(m => m.Value.GetInstance()).ToArray();
    }
}