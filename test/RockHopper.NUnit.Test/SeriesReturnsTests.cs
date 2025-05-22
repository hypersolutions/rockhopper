using NUnit.Framework;
using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;
using RockHopper.Mocking.Parameters;
using RockHopper.TestSupport.Calculation;

namespace RockHopper.NUnit.Test;

public class SeriesReturnsTests
{
    [Test]
    public void SequentialNumbersWithMismatchMock_AddNumberSeries_ThrowsExceptions()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(Param.IsAny<int>(), Param.IsAny<int>())).Returns(3, 6, 10);

        var exception = Should.Throw<MockException>(() => calculatorService.AddNumberSeries(1, 2, 3, 4, 5));
        
        exception.Message.ShouldBe("The return value sequence exceeds the request.");
    }
    
    [Test]
    public void SequentialNumbers_AddNumberSeries_ReturnsTotal()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(Param.IsAny<int>(), Param.IsAny<int>())).Returns(3, 6, 10, 15);

        var result = calculatorService.AddNumberSeries(1, 2, 3, 4, 5);
        
        result.ShouldBe(15);
        
        calculatorService.VerifyAll();
    }
    
    [Test]
    public void SequentialNumbers_AddNumberSeries_VerifiesThatAllCallsMade()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(Param.IsAny<int>(), Param.IsAny<int>())).Returns(3, 6, 10, 15);

        calculatorService.AddNumberSeries(1, 2, 3, 4, 5);
        
        calculatorService.VerifyAll();
    }
    
    [Test]
    public void SequentialNumbersWithMissingMockCall_AddNumberSeries_ThrowsException()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(Param.IsAny<int>(), Param.IsAny<int>())).Returns(3, 6, 10, 15);

        calculatorService.AddNumberSeries(1, 2, 3, 4);
        
        var exception = Should.Throw<VerificationException>(() => calculatorService.VerifyAll());
        exception.Message.ShouldBe("Verification mismatch: Expected 4; Actual 3");
    }
}