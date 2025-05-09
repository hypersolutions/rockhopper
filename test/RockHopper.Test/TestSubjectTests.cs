using RockHopper.Assertions;
using RockHopper.Exceptions;
using RockHopper.Mocking.Exceptions;
using RockHopper.TestSupport;

namespace RockHopper.Test;

public class TestSubjectTests
{
    [Fact]
    public void SubjectWithDependency_ImplicitCast_ReturnsNonNullInstance()
    {
        var testSubject = new TestSubject<CalculatorService>();
        
        CalculatorService calculatorService = testSubject;
        
        calculatorService.ShouldNotBeNull();
    }

    [Fact]
    public void SubjectWithDependency_Value_ReturnsNonNullInstance()
    {
        var testSubject = new TestSubject<CalculatorService>();
        
        var calculatorService = testSubject.Value;
        
        calculatorService.ShouldNotBeNull();
    }
    
    [Fact]
    public void UnknownMock_GetMock_ThrowsException()
    {
        var testSubject = new TestSubject<CalculatorService>();
        var exception = Should.Throw<TestException>(() => testSubject.GetMock<IAccountManager>());
        
        exception.Message.ShouldBe($"Unable to find a mock for {typeof(IAccountManager)}.");
    }
    
    [Fact]
    public void SubjectWithDependency_GetMock_ReturnsNonNullMock()
    {
        var testSubject = new TestSubject<CalculatorService>();
        
        var calculator = testSubject.GetMock<Calculator>();
        
        calculator.ShouldNotBeNull();
    }
    
    [Fact]
    public void SubjectWithDependency_Value_ReturnsSameInstanceForTest()
    {
        var testSubject = new TestSubject<CalculatorService>();
        var calculatorService1 = testSubject.Value;

        var calculatorService2 = testSubject.Value;
        
        calculatorService1.ShouldBe(calculatorService2);
    }
    
    [Fact]
    public void SubjectWithDependency_GetMock_ReturnsSameInstanceForTest()
    {
        var testSubject = new TestSubject<CalculatorService>();
        var calculator1 = testSubject.GetMock<Calculator>();
        
        var calculator2 = testSubject.GetMock<Calculator>();
        
        calculator1.ShouldBe(calculator2);
    }
    
    [Fact]
    public void AllMocksUsed_VerifyAll_CallsMockedCalculator()
    {
        var testSubject = new TestSubject<CalculatorService>();
        CalculatorService calculatorService = testSubject;
        var calculator = testSubject.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        Should.NotThrow<VerificationException>(() => testSubject.VerifyAll());
    }
    
    [Fact]
    public void UnusedMock_VerifyAll_ThrowsException()
    {
        var testSubject = new TestSubject<CalculatorService>();
        CalculatorService calculatorService = testSubject;
        var calculator = testSubject.GetMock<Calculator>();
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculator.Setup(c => c.Add(1, 2)).Returns(30);
        
        calculatorService.AddNumbers(10, 20);
        
        Should.Throw<VerificationException>(() => testSubject.VerifyAll());
    }
    
    [Fact]
    public void ReusingAllMocksBetweenVerifies_VerifyAll_Succeeds()
    {
        var testSubject = new TestSubject<CalculatorService>();
        CalculatorService calculatorService = testSubject;
        var calculator = testSubject.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        testSubject.VerifyAll();
        
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        Should.NotThrow<VerificationException>(() => testSubject.VerifyAll());
    }
    
    [Fact]
    public void NotReusingAllMocksBetweenVerifies_VerifyAll_ThrowsException()
    {
        var testSubject = new TestSubject<CalculatorService>();
        CalculatorService calculatorService = testSubject;
        var calculator = testSubject.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        testSubject.VerifyAll();
        
        calculatorService.AddNumbers(1, 2);
        
        Should.Throw<VerificationException>(() => testSubject.VerifyAll());
    }
}