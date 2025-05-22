using System.Reflection;

namespace RockHopper.Builder;

internal sealed class DefaultConstructorSelector : IConstructorSelector
{
    public ConstructorInfo GetConstructor<TSubject>(params Type[] parameterTypes)
    {
        return typeof(TSubject).GetConstructors().First();
    }
}