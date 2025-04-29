namespace RockHopper.Enums;

/// <summary>
/// List of options to create a subject with mocks. These can be combined.
/// </summary>
[Flags]
public enum SubjectBuilderFlags
{
    /// <summary>
    /// Create mocks for types defined in the constructor.
    /// </summary>
    Constructor = 1,
    
    /// <summary>
    /// Create mocks for types defined on any public properties that support set or init.
    /// </summary>
    Property = 2,
    
    /// <summary>
    /// Create with both constructor and property matches.
    /// </summary>
    All = 3
}