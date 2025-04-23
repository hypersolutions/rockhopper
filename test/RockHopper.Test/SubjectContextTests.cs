using RockHopper.Assertions;
using RockHopper.Enums;
using RockHopper.Exceptions;
using RockHopper.Test.Support;

namespace RockHopper.Test;

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
    public void DefaultParameters_CreateSubject_CanMock()
    {
        var user = new TestUser();
        var repository = SubjectContext.Current.CreateSubject<TestRepository>();
        var config = SubjectContext.Current.GetMock<TestConfig>();
        config.Setup(c => c.Connection).Returns("localhost");
        var dbContext = SubjectContext.Current.GetMock<ITestDbContext>();
        dbContext.Setup(c => c.Save(user, "localhost")).Returns(true);

        var saved = repository.Save(user);
        
        saved.ShouldBeTrue();
        SubjectContext.Current.VerifyAll();
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
        var repository = SubjectContext.Current.CreateSubject<TestRepository>(SubjectBuilderFlags.All);
        
        repository.ShouldNotBeNull();
        repository.Logger.ShouldNotBeNull();
    }
}