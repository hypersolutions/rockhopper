using System.Runtime.CompilerServices;

namespace RockHopper.Test;

/// <summary>
/// Defines a test method.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TestAttribute : Attribute
{
    /// <summary>
    /// Constructs the test attribute.
    /// </summary>
    /// <param name="filePath">Helper for the test file path</param>
    /// <param name="lineNumber">Helper for the test line number</param>
    public TestAttribute([CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        FilePath = filePath;
        LineNumber = lineNumber;
    }
    
    /// <summary>
    /// Helper to identify the file path for IDEs.
    /// </summary>
    public string FilePath { get; }
    
    /// <summary>
    /// Helper to identify the line number for IDEs.
    /// </summary>
    public int LineNumber { get; }
    
    /// <summary>
    /// Set a description for the test.
    /// </summary>
    public string? Description { get; init; }
    
    /// <summary>
    /// Set a skip message if you require skipping the test.
    /// </summary>
    public string? Skip { get; init; }

    /// <summary>
    /// Set any inline arguments for the test. 
    /// </summary>
    public object?[]? InlineArgs { get; init; }

    // /// <summary>
    // /// Set any class arguments using a class type.
    // /// </summary>
    public Type? ClassArgs { get; init; }
    
    /// <summary>
    /// Set any member arguments using a static property in the class.
    /// </summary>
    public string? MemberArgs { get; init; }

    internal bool HasNoArgs => (InlineArgs is null || InlineArgs?.Length == 0) && ClassArgs is null && MemberArgs is null;
}