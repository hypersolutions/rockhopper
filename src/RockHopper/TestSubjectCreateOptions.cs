using RockHopper.Builder;

namespace RockHopper;

/// <summary>
/// Test subject creation options.
/// </summary>
public sealed class TestSubjectCreateOptions
{
    /// <summary>
    /// The default test subject creation mode. This will look for the first constructor and mock the parameters. Any
    /// properties will be ignored.
    /// </summary>
    public static readonly TestSubjectCreateOptions Default = new()
    {
        MockParameters = true,
        MockProperties = false,
        ConstructorSelector = new DefaultConstructorSelector()
    };
    
    /// <summary>
    /// Gets or sets whether constructor parameters should be mocked.
    /// </summary>
    public bool MockParameters { get; init; }
    
    /// <summary>
    /// Gets or sets whether properties should be mocked.
    /// </summary>
    public bool MockProperties { get; init; }

    /// <summary>
    /// Gets or sets the way in which the test subject constructor is determined. Uses the first constructor by default.
    /// </summary>
    public IConstructorSelector ConstructorSelector { get; init; } = new DefaultConstructorSelector();

    /// <summary>
    /// Gets or sets the list of args to pass to the constructor selector.
    /// </summary>
    public Type[] ConstructorSelectorArgs { get; init; } = [];
    
    internal string GetKey<TSubject>()
    {
        var mockActivation = $"Ctor={MockParameters};Props={MockProperties}";
        return $"{typeof(TSubject).FullName}.{ConstructorSelector.GetType().FullName}.{mockActivation}";
    }
}