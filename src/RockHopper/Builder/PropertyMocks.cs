using System.Reflection;
using RockHopper.Mocking;

namespace RockHopper.Builder;

internal sealed class PropertyMocks : Dictionary<PropertyInfo, Mock>
{
    internal object[] GetInstances()
    {
        return this.Select(m => m.Value.GetInstance()).ToArray();
    }
}