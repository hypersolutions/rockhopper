using RockHopper.Assertions;

namespace RockHopper.Test.Assertions;

public class ShouldBeTests : ShouldBaseTest
{
    [Test]
    public void IntValue_ShouldBe_NotThrowException()
    {
        const int expected = 10;
        const int actual = 10;
        
        ShouldNotThrow<int>(() => actual.ShouldBe(expected));
    }
    
    [Test]
    public void IntValue_ShouldBe_ThrowsException()
    {
        const int expected = 10;
        const int actual = 20;

        ShouldThrow(() => actual.ShouldBe(expected), expected, actual);
    }
    
    [Test]
    public void StringValue_ShouldBe_NotThrowException()
    {
        const string expected = "Test";
        const string actual = "Test";
        
        ShouldNotThrow<string>(() => actual.ShouldBe(expected));
    }
    
    [Test]
    public void StringValue_ShouldBe_ThrowsException()
    {
        const string expected = "Test";
        const string actual = "Test2";

        ShouldThrow(() => actual.ShouldBe(expected), expected, actual);
    }
    
    [Test]
    public void ObjectValue_ShouldBe_NotThrowException()
    {
        object expected = new TestObject("Test");
        object actual = expected;
        
        ShouldNotThrow<string>(() => actual.ShouldBe(expected));
    }
    
    [Test]
    public void ObjectValue_ShouldBe_ThrowsException()
    {
        object expected = new TestObject("Test");
        object actual = new TestObject("Test");

        ShouldThrow(() => actual.ShouldBe(expected), expected, actual);
    }

    private class TestObject(string Name);
}