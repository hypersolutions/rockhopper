using System.Reflection;

namespace RockHopper.Builder;

/// <summary>
/// Defines the interface for selecting a constructor in the subject builder.
/// </summary>
public interface IConstructorSelector
{
    /// <summary>
    /// Gets a constructor for the subject type.
    /// </summary>
    /// <param name="parameterTypes">List of any argument values you wish to pass to locate a constructor</param>
    /// <typeparam name="TSubject">Subject type</typeparam>
    /// <returns>Constructor info</returns>
    ConstructorInfo GetConstructor<TSubject>(params Type[] parameterTypes);
}