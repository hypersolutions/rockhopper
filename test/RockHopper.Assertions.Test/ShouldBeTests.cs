namespace RockHopper.Assertions.Test;

public class ShouldBeTests : ShouldBaseTest
{
    [Fact]
    public void IntValue_ShouldBe_NotThrowException()
    {
        const int expected = 10;
        const int actual = 10;
        
        ShouldNotThrow<int>(() => actual.ShouldBe(expected));
    }
    
    [Fact]
    public void IntValue_ShouldBe_ThrowsException()
    {
        const int expected = 10;
        const int actual = 20;

        ShouldThrow(() => actual.ShouldBe(expected), expected, actual);
    }
    
    [Fact]
    public void StringValue_ShouldBe_NotThrowException()
    {
        const string expected = "Test";
        const string actual = "Test";
        
        ShouldNotThrow<string>(() => actual.ShouldBe(expected));
    }
    
    [Fact]
    public void StringValue_ShouldBe_ThrowsException()
    {
        const string expected = "Test";
        const string actual = "Test2";

        ShouldThrow(() => actual.ShouldBe(expected), expected, actual);
    }
    
    [Fact]
    public void ObjectValue_ShouldBe_NotThrowException()
    {
        object expected = new TestObject("Test");
        object actual = expected;
        
        ShouldNotThrow<string>(() => actual.ShouldBe(expected));
    }
    
    [Fact]
    public void ObjectValue_ShouldBe_ThrowsException()
    {
        object expected = new TestObject("Test");
        object actual = new TestObject("Test");

        ShouldThrow(() => actual.ShouldBe(expected), expected, actual);
    }
    
    [Fact]
    public void MatchingIntValue_ShouldNotBe_ThrowsException()
    {
        const int expected = 10;
        const int actual = 10;

        ShouldThrow(() => actual.ShouldNotBe(expected), expected, actual);
    }
    
    [Fact]
    public void NonMatchingIntValue_ShouldNotBe_NotThrowException()
    {
        const int expected = 10;
        const int actual = 20;

        ShouldNotThrow<int>(() => actual.ShouldNotBe(expected));
    }

    private class TestObject(string name)
    {
        public string Name { get; } = name;

        public override string ToString() => Name;
    }
}