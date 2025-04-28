using RockHopper.Assertions;
using RockHopper.Exceptions;
using RockHopper.Mocking.Exceptions;
using RockHopper.TestSupport;

namespace RockHopper.XUnit.Test;

public class SubjectBuilderIntTests
{
    [Fact]
    public void SubjectWithDependency_CreateSubject_ReturnsNonNullInstance()
    {
        var subjectInfo = SubjectBuilder.Create<CalculatorService>();
        
        var calculatorService = subjectInfo.Value;
        
        calculatorService.ShouldNotBeNull();
    }
    
    [Fact]
    public void UnknownMock_GetMock_ThrowsException()
    {
        var subjectInfo = SubjectBuilder.Create<CalculatorService>();
        var exception = Should.Throw<TestException>(() => subjectInfo.GetMock<IAccountManager>());
        
        exception.Message.ShouldBe($"Unable to find a mock for {typeof(IAccountManager)}.");
    }
    
    [Fact]
    public void SubjectWithDependency_GetMock_ReturnsNonNullMock()
    {
        var subjectInfo = SubjectBuilder.Create<CalculatorService>();
        _ = subjectInfo.Value;
        
        var calculator = subjectInfo.GetMock<Calculator>();
        
        calculator.ShouldNotBeNull();
    }
    
    [Fact]
    public void SubjectWithDependency_CreateSubject_ReturnsSameInstanceForTest()
    {
        var subjectInfo = SubjectBuilder.Create<CalculatorService>();
        var calculatorService1 = subjectInfo.Value;

        var calculatorService2 = subjectInfo.Value;
        
        calculatorService1.ShouldBe(calculatorService2);
    }
    
    [Fact]
    public void SubjectWithDependency_GetMock_ReturnsSameInstanceForTest()
    {
        var subjectInfo = SubjectBuilder.Create<CalculatorService>();
        _ = subjectInfo.Value;
        var calculator1 = subjectInfo.GetMock<Calculator>();
        
        var calculator2 = subjectInfo.GetMock<Calculator>();
        
        calculator1.ShouldBe(calculator2);
    }
    
    [Fact]
    public void AllMocksUsed_VerifyAll_CallsMockedCalculator()
    {
        var subjectInfo = SubjectBuilder.Create<CalculatorService>();
        var calculatorService = subjectInfo.Value;
        var calculator = subjectInfo.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        Should.NotThrow<VerificationException>(() => subjectInfo.VerifyAll());
    }
    
    [Fact]
    public void UnusedMock_VerifyAll_ThrowsException()
    {
        var subjectInfo = SubjectBuilder.Create<CalculatorService>();
        var calculatorService = subjectInfo.Value;
        var calculator = subjectInfo.GetMock<Calculator>();
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculator.Setup(c => c.Add(1, 2)).Returns(30);
        calculatorService.AddNumbers(10, 20);
        
        Should.Throw<VerificationException>(() => subjectInfo.VerifyAll());
    }
    
    [Fact]
    public void ReusingAllMocksBetweenVerifies_VerifyAll_Succeeds()
    {
        var subjectInfo = SubjectBuilder.Create<CalculatorService>();
        var calculatorService = subjectInfo.Value;
        var calculator = subjectInfo.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        subjectInfo.VerifyAll();
        
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        Should.NotThrow<VerificationException>(() => subjectInfo.VerifyAll());
    }
    
    [Fact]
    public void NotReusingAllMocksBetweenVerifies_VerifyAll_ThrowsException()
    {
        var subjectInfo = SubjectBuilder.Create<CalculatorService>();
        var calculatorService = subjectInfo.Value;
        var calculator = subjectInfo.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        subjectInfo.VerifyAll();
        
        calculatorService.AddNumbers(1, 2);
        
        Should.Throw<VerificationException>(() => subjectInfo.VerifyAll());
    }
}