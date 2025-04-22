using RockHopper.Assertions;
using RockHopper.Exceptions;
using RockHopper.Mocking.Test.Support;

namespace RockHopper.Mocking.Test;

public class SubjectContextTests
{
    [Fact]
    public void DefaultParameters_CreateSubject_ReturnsInstance()
    {
        var repository = SubjectContext.Current.CreateSubject<TestRepository>();
        
        repository.ShouldNotBeNull();
    }
    
    [Fact]
    public void DefaultParameters_CreateSubject_ReturnsInstanceWithNullPropertyInjected()
    {
        var repository = SubjectContext.Current.CreateSubject<TestRepository>();
        
        repository.Logger.ShouldBeNull();
    }
    
    [Fact]
    public void PropertyInjectionOnly_CreateSubject_ThrowsException()
    {
        var exception = Should.Throw<TestException>(
            () => SubjectContext.Current.CreateSubject<TestRepository>(SubjectBuilderFlags.Property));
        
        exception.Message.ShouldBe("There is no parameterless constructor for the subject using property injection only.");
    }
    
    [Fact]
    public void BothConstructorAndPropertyInjection_CreateSubject_ReturnsInstanceFullyMocked()
    {
        const SubjectBuilderFlags args = SubjectBuilderFlags.Constructor | SubjectBuilderFlags.Property;
        
        var repository = SubjectContext.Current.CreateSubject<TestRepository>(args);
        
        repository.ShouldNotBeNull();
        repository.Logger.ShouldNotBeNull();
    }
}