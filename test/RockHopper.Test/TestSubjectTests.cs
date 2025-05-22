using System.Reflection;
using RockHopper.Assertions;
using RockHopper.Builder;
using RockHopper.Exceptions;
using RockHopper.Mocking.Exceptions;
using RockHopper.TestSupport.Banking;
using RockHopper.TestSupport.Calculation;
using RockHopper.TestSupport.Conversion;
using RockHopper.TestSupport.Formatting;

namespace RockHopper.Test;

public class TestSubjectTests
{
    [Fact]
    public void SubjectWithDependency_Create_ReturnsNonNullInstance()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        
        calculatorService.ShouldNotBeNull();
    }
    
    [Fact]
    public void SubjectWithDependency_Create_ReturnsDifferentInstanceEachTime()
    {
        var calculatorService1 = TestSubject.Create<CalculatorService>();

        var calculatorService2 = TestSubject.Create<CalculatorService>();
        
        calculatorService1.ShouldNotBe(calculatorService2);
    }
    
    [Fact]
    public void UnknownMock_GetMock_ThrowsException()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var exception = Should.Throw<TestException>(() => calculatorService.GetMock<IAccountManager>());
        
        exception.Message.ShouldBe($"Unable to find a mock for {typeof(IAccountManager)}.");
    }
    
    [Fact]
    public void SubjectWithDependency_GetMock_ReturnsNonNullMock()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        
        var calculator = calculatorService.GetMock<Calculator>();
        
        calculator.ShouldNotBeNull();
    }
    
    [Fact]
    public void SubjectWithDependency_GetMock_ReturnsSameInstanceForTest()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator1 = calculatorService.GetMock<Calculator>();
        
        var calculator2 = calculatorService.GetMock<Calculator>();
        
        calculator1.ShouldBe(calculator2);
    }
    
    [Fact]
    public void AllMocksUsed_VerifyAll_CallsMockedCalculator()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(1, 2)).Returns(3);
        calculator.Function(c => c.Add(10, 20)).Returns(30);
        
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        Should.NotThrow<VerificationException>(() => calculatorService.VerifyAll());
    }
    
    [Fact]
    public void UnusedMock_VerifyAll_ThrowsException()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(10, 20)).Returns(30);
        calculator.Function(c => c.Add(1, 2)).Returns(30);
        
        calculatorService.AddNumbers(10, 20);
        
        Should.Throw<VerificationException>(() => calculatorService.VerifyAll());
    }
    
    [Fact]
    public void ReusingAllMocksBetweenVerifies_VerifyAll_Succeeds()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(1, 2)).Returns(3);
        calculator.Function(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        calculatorService.VerifyAll();
        
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        
        Should.NotThrow<VerificationException>(() => calculatorService.VerifyAll());
    }
    
    [Fact]
    public void NotReusingAllMocksBetweenVerifies_VerifyAll_ThrowsException()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(1, 2)).Returns(3);
        calculator.Function(c => c.Add(10, 20)).Returns(30);
        calculatorService.AddNumbers(1, 2);
        calculatorService.AddNumbers(10, 20);
        calculatorService.VerifyAll();
        
        calculatorService.AddNumbers(1, 2);
        
        Should.Throw<VerificationException>(() => calculatorService.VerifyAll());
    }
    
    [Fact]
    public void PropertyDependency_Create_SetsPropertyWithMock()
    {
        var options = new TestSubjectCreateOptions { MockProperties = true };
        
        var textFormatterService = TestSubject.Create<TextFormatterService>(options);
        
        var textLogger = textFormatterService.GetMock<TextLogger>();
        textFormatterService.Logger.ShouldBe(textLogger.Object);
    }

    [Fact]
    public void SingleParameterConstructor_Create_BuildsTestSubject()
    {
        var options = new TestSubjectCreateOptions
        {
            MockParameters = true, 
            ConstructorSelector = new SingleParamConstructorSelector()
        };

        var currencyService = TestSubject.Create<ConverterService>(options);
        
        currencyService.ShouldNotBeNull();
    }
    
    [Fact]
    public void SpecificParameterConstructor_Create_BuildsTestSubject()
    {
        var options = new TestSubjectCreateOptions
        {
            MockParameters = true,
            ConstructorSelector = new SpecificParamConstructorSelector(),
            ConstructorSelectorArgs = [typeof(IIntConverter)]
        };

        var currencyService = TestSubject.Create<ConverterService>(options);
        
        currencyService.ShouldNotBeNull();
    }
    
    private class SingleParamConstructorSelector : IConstructorSelector
    {
        public ConstructorInfo GetConstructor<TSubject>(params Type[] parameterTypes)
        {
            return typeof(TSubject).GetConstructors().First(c => c.GetParameters().Length == 1);
        }
    }
    
    private class SpecificParamConstructorSelector : IConstructorSelector
    {
        public ConstructorInfo GetConstructor<TSubject>(params Type[] parameterTypes)
        {
            return typeof(TSubject).GetConstructors().First(
                c => c.GetParameters().Length == 1 && c.GetParameters()[0].ParameterType == parameterTypes[0]);
        }
    }
}