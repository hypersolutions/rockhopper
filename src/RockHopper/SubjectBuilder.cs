using RockHopper.Builder;
using RockHopper.Enums;

namespace RockHopper;

/// <summary>
/// Builds the subject info factory to create a subject and its mock dependencies.
/// </summary>
public static class SubjectBuilder
{
    /// <summary>
    /// Create the subject info and mock dependency information.
    /// </summary>
    /// <param name="builderFlags">How to construct the subject</param>
    /// <param name="constructorSelector">How to choose the constructor - defaults to the first constructor</param>
    /// <typeparam name="TSubject">Subject type</typeparam>
    /// <returns>Subject information to build the subject with</returns>
    public static SubjectInfo<TSubject> Create<TSubject>(
        SubjectBuilderFlags builderFlags = SubjectBuilderFlags.Constructor,
        IConstructorSelector? constructorSelector = null)
    {
        return new SubjectInfo<TSubject>(builderFlags, constructorSelector ?? new DefaultConstructorSelector());
    }
}