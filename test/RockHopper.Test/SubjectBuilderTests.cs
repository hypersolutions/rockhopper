using RockHopper.Assertions;
using RockHopper.Enums;
using RockHopper.Exceptions;
using RockHopper.Test.Support;

namespace RockHopper.Test;

public class SubjectBuilderTests
{
    [Fact]
    public void DefaultParameters_Value_ReturnsInstance()
    {
        var subjectInfo = SubjectBuilder.Create<TestRepository>();
        
        subjectInfo.Value.ShouldNotBeNull();
    }
    
    [Fact]
    public void RequestCtorMockForDefaultParameters_GetMock_ReturnsMockInstance()
    {
        var subjectInfo = SubjectBuilder.Create<TestRepository>();
        _ = subjectInfo.Value;
        
        var dbContext = subjectInfo.GetMock<ITestDbContext>();
        
        dbContext.ShouldNotBeNull();
    }
    
    [Fact]
    public void RequestPropMockForDefaultParameters_GetMock_ReturnsNull()
    {
        var subjectInfo = SubjectBuilder.Create<TestRepository>();

        var exception = Should.Throw<TestException>(() => subjectInfo.GetMock<ITestLogger>());
        
        exception.Message.ShouldBe($"Unable to find a mock for {typeof(ITestLogger)}.");
    }
    
    [Fact]
    public void DefaultParameters_CreateSubject_ReturnsInstanceWithNullPropertyInjected()
    {
        var subjectInfo = SubjectBuilder.Create<TestRepository>();
        
        subjectInfo.Value.Logger.ShouldBeNull();
    }
    
    [Fact]
    public void DefaultParameters_CreateSubject_CanMock()
    {
        var user = new TestUser();
        var subjectInfo = SubjectBuilder.Create<TestRepository>();
        _ = subjectInfo.Value;
        var config = subjectInfo.GetMock<TestConfig>();
        config.Setup(c => c.Connection).Returns("localhost");
        var dbContext = subjectInfo.GetMock<ITestDbContext>();
        dbContext.Setup(c => c.Save(user, "localhost")).Returns(true);

        var saved = subjectInfo.Value.Save(user);
        
        saved.ShouldBeTrue();
        subjectInfo.VerifyAll();
    }
    
    [Fact]
    public void PropertyInjectionOnly_Create_ThrowsException()
    {
        var exception = Should.Throw<TestException>(() => SubjectBuilder.Create<TestRepository>(SubjectBuilderFlags.Property));
        
        exception.Message.ShouldBe("There is no parameterless constructor for the subject using property injection only.");
    }
    
    [Fact]
    public void BothConstructorAndPropertyInjection_CreateSubject_ReturnsInstanceFullyMocked()
    {
        var subjectInfo = SubjectBuilder.Create<TestRepository>(SubjectBuilderFlags.All);
        
        subjectInfo.Value.ShouldNotBeNull();
        subjectInfo.Value.Logger.ShouldNotBeNull();
    }
    
    [Fact]
    public void SameSubjectRequest_CreateSubject_ReturnsSameInstanceForTest()
    {
        var subjectInfo = SubjectBuilder.Create<TestRepository>();
        var testRepository1 = subjectInfo.Value;
        
        var testRepository2 = subjectInfo.Value;
        
        testRepository1.ShouldBe(testRepository2);
    }
}