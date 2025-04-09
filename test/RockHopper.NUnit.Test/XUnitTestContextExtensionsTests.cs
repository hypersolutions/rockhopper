using NUnit.Framework;
using RockHopper.Assertions;
using RockHopper.Exceptions;
using RockHopper.Mocking.Exceptions;
using RockHopper.NUnit.Test.TestSupport;

namespace RockHopper.NUnit.Test;

public class XUnitTestContextExtensionsTests
{
    [Test]
    public void SubjectWithDependency_CreateSubject_ReturnsNonNullInstance()
    {
        var calculatorService = TestContext.CurrentContext.CreateSubject<CalculatorService>();
        
        calculatorService.ShouldNotBeNull();
    }
    
    [Test]
    public void MockWithoutCreatingSubject_GetMock_ThrowsException()
    {
        var exception = Should.Throw<TestException>(() => TestContext.CurrentContext.GetMock<Calculator>());
        
        exception.Message.ShouldBe("No test mocks exist. You need to call the CreateSubject first.");
    }
    
    [Test]
    public void SubjectWithDependency_GetMock_ReturnsNonNullMock()
    {
        TestContext.CurrentContext.CreateSubject<CalculatorService>();
        
        var calculator = TestContext.CurrentContext.GetMock<Calculator>();
        
        calculator.ShouldNotBeNull();
    }
    
    [Test]
    public void SubjectWithDependency_CreateSubject_ReturnsSameInstanceForTest()
    {
        var calculatorService1 = TestContext.CurrentContext.CreateSubject<CalculatorService>();
        
        var calculatorService2 = TestContext.CurrentContext.CreateSubject<CalculatorService>();
        
        calculatorService1.ShouldBe(calculatorService2);
    }
    
    [Test]
    public void SubjectWithDependency_GetMock_ReturnsSameInstanceForTest()
    {
        TestContext.CurrentContext.CreateSubject<CalculatorService>();
        var calculator1 = TestContext.CurrentContext.GetMock<Calculator>();
        
        var calculator2 = TestContext.CurrentContext.GetMock<Calculator>();
        
        calculator1.ShouldBe(calculator2);
    }
    
    [Test]
    public void AllMocksUsed_VerifyAll_CallsMockedCalculator()
    {
        var calculatorService = TestContext.CurrentContext.CreateSubject<CalculatorService>();
        var calculator = TestContext.CurrentContext.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        Should.NotThrow<VerificationException>(() => TestContext.CurrentContext.VerifyAll());
    }
    
    [Test]
    public void UnusedMock_VerifyAll_ThrowsException()
    {
        var calculatorService = TestContext.CurrentContext.CreateSubject<CalculatorService>();
        var calculator = TestContext.CurrentContext.GetMock<Calculator>();
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculator.Setup(c => c.Add(1, 2)).Returns(30);
        calculatorService.AddNumbers(10, 20);
        
        Should.Throw<VerificationException>(() => TestContext.CurrentContext.VerifyAll());
    }
    
    [Test]
    public void ReusingAllMocksBetweenVerifies_VerifyAll_Succeeds()
    {
        var calculatorService = TestContext.CurrentContext.CreateSubject<CalculatorService>();
        var calculator = TestContext.CurrentContext.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        TestContext.CurrentContext.VerifyAll();
        
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        Should.NotThrow<VerificationException>(() => TestContext.CurrentContext.VerifyAll());
    }
    
    [Test]
    public void NotReusingAllMocksBetweenVerifies_VerifyAll_ThrowsException()
    {
        var calculatorService = TestContext.CurrentContext.CreateSubject<CalculatorService>();
        var calculator = TestContext.CurrentContext.GetMock<Calculator>();
        calculator.Setup(c => c.Add(1, 2)).Returns(3);
        calculator.Setup(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        TestContext.CurrentContext.VerifyAll();
        
        calculatorService.AddNumbers(1, 2);
        
        Should.Throw<VerificationException>(() => TestContext.CurrentContext.VerifyAll());
    }
}