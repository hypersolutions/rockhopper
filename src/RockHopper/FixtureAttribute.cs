
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace RockHopper;

[AttributeUsage(AttributeTargets.Class)]
public sealed class FixtureAttribute : Attribute
{
    public Type? Class { get; init; }
    
    public Type? Shared { get; init; }
}