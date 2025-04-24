using RockHopper.Assertions;
using RockHopper.Exceptions;
using RockHopper.Mocking.Exceptions;
using RockHopper.TestSupport;

namespace RockHopper.XUnit.Test;

public class SubjectContextIntTests
{
    [Fact]
    public void SubjectWithDependency_CreateSubject_ReturnsNonNullInstance()
    {
        var calculatorService = SubjectContext.Current.CreateSubject<CalculatorService>();
        
        calculatorService.ShouldNotBeNull();
    }
    
    [Fact]
    public void MockWithoutCreatingSubject_GetMock_ThrowsException()
    {
        var exception = Should.Throw<TestException>(() => SubjectContext.Current.GetMock<Calculator>());
        
        exception.Message.ShouldBe("No test mocks exist. You need to call the CreateSubject first.");
    }
    
    [Fact]
    public void SubjectWithDependency_GetMock_ReturnsNonNullMock()
    {
        SubjectContext.Current.CreateSubject<CalculatorService>();
        
        var calculator = SubjectContext.Current.GetMock<Calculator>();
        
        calculator.ShouldNotBeNull();
    }
    
    [Fact]
    public void SubjectWithDependency_CreateSubject_ReturnsSameInstanceForTest()
    {
        var calculatorService1 = SubjectContext.Current.CreateSubject<CalculatorService>();
        
        var calculatorService2 = SubjectContext.Current.CreateSubject<CalculatorService>();
        
        calculatorService1.ShouldBe(calculatorService2);
    }
    
    [Fact]
    public async Task SubjectRequestPerTask_GetMock_ReturnsDifferentInstanceForTest()
    {
        SubjectContext.Current.CreateSubject<CalculatorService>();
        var calculator1 = await Task.FromResult(() => SubjectContext.Current.GetMock<Calculator>());
        
        var calculator2 = await Task.FromResult(() => SubjectContext.Current.GetMock<Calculator>());
        
        calculator1.ShouldNotBe(calculator2);
    }
    
    [Fact]
    public void SubjectWithDependency_GetMock_ReturnsSameInstanceForTest()
    {
        SubjectContext.Current.CreateSubject<CalculatorService>();
        var calculator1 = SubjectContext.Current.GetMock<Calculator>();
        
        var calculator2 = SubjectContext.Current.GetMock<Calculator>();
        
        calculator1.ShouldBe(calculator2);
    }
    
    [Fact]
    public void AllMocksUsed_VerifyAll_CallsMockedCalculator()
    {
        var calculatorService = SubjectContext.Current.CreateSubject<CalculatorService>();
        var calculator = SubjectContext.Current.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        Should.NotThrow<VerificationException>(() => SubjectContext.Current.VerifyAll());
    }
    
    [Fact]
    public void UnusedMock_VerifyAll_ThrowsException()
    {
        var calculatorService = SubjectContext.Current.CreateSubject<CalculatorService>();
        var calculator = SubjectContext.Current.GetMock<Calculator>();
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculator.Setup(c => c.Add(1, 2)).Returns(30);
        calculatorService.AddNumbers(10, 20);
        
        Should.Throw<VerificationException>(() => SubjectContext.Current.VerifyAll());
    }
    
    [Fact]
    public void ReusingAllMocksBetweenVerifies_VerifyAll_Succeeds()
    {
        var calculatorService = SubjectContext.Current.CreateSubject<CalculatorService>();
        var calculator = SubjectContext.Current.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        SubjectContext.Current.VerifyAll();
        
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        Should.NotThrow<VerificationException>(() => SubjectContext.Current.VerifyAll());
    }
    
    [Fact]
    public void NotReusingAllMocksBetweenVerifies_VerifyAll_ThrowsException()
    {
        var calculatorService = SubjectContext.Current.CreateSubject<CalculatorService>();
        var calculator = SubjectContext.Current.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        SubjectContext.Current.VerifyAll();
        
        calculatorService.AddNumbers(1, 2);
        
        Should.Throw<VerificationException>(() => SubjectContext.Current.VerifyAll());
    }
}