using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;

namespace RockHopper.Test.Mocking.Exceptions;

public class StrictMockViolationExceptionTests 
{
    private static readonly Type _testClassType = typeof(StrictMockViolationExceptionTests);

    private const string MessageTemplate = "There is no setup for the call '{0}'. " +
                                           "All calls using a strict mock must be defined.";
    
    [Fact]
    public void ForMethod_Message_ContainsExceptionFormattedMessage()
    {
        var method = _testClassType.GetMethod(nameof(TestMethod))!;
        
        var exception = new StrictMockViolationException(method);
        
        exception.Message.ShouldBe(string.Format(MessageTemplate, nameof(TestMethod)));
    }
    
    [Fact]
    public void ForGetProperty_Message_ContainsExceptionFormattedMessage()
    {
        var method = _testClassType.GetProperty(nameof(TestProperty))!;
        
        var exception = new StrictMockViolationException(method.GetMethod!);
        
        exception.Message.ShouldBe(string.Format(MessageTemplate, nameof(TestProperty)));
    }
    
    [Fact]
    public void ForSetProperty_Message_ContainsExceptionFormattedMessage()
    {
        var method = _testClassType.GetProperty(nameof(TestProperty))!;
        
        var exception = new StrictMockViolationException(method.SetMethod!);
        
        exception.Message.ShouldBe(string.Format(MessageTemplate, nameof(TestProperty)));
    }
    
    [Fact]
    public void ForGetIndexer_Message_ContainsExceptionFormattedMessage()
    {
        var property = _testClassType.GetProperty("Item")!;
        
        var exception = new StrictMockViolationException(property.GetMethod!);
        
        exception.Message.ShouldBe(string.Format(MessageTemplate, "Item"));
    }
    
    [Fact]
    public void ForSetIndexer_Message_ContainsExceptionFormattedMessage()
    {
        var property = _testClassType.GetProperty("Item")!;
        
        var exception = new StrictMockViolationException(property.SetMethod!);
        
        exception.Message.ShouldBe(string.Format(MessageTemplate, "Item"));
    }

#pragma warning disable xUnit1013
    
    public string? TestProperty { get; set; }

    // ReSharper disable once UnusedMember.Global
    public int this[int index]
    {
        get => index;
        set => _ = value;
    }

    public static void TestMethod()
    {
    }
    
#pragma warning restore xUnit1013
}