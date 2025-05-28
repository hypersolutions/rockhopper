using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;
using RockHopper.TestSupport.Calculation;
using RockHopper.TestSupport.Extensions;

namespace RockHopper.TUnit.Test;

public class ParameterExtensionTests
{
    [Test]
    public void ParamGreaterThanValue_AddNumberSeries_ThrowsException()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(ParamEx.IsLessThan(10), 2)).Returns(3);

        var exception = Should.Throw<StrictMockViolationException>(() => calculatorService.AddNumberSeries(10, 2));
        
        exception.Message.ShouldBe("There is no setup for the call 'Add'. All calls using a strict mock must be defined.");
    }
    
    [Test]
    public void ParamLessThanValue_AddNumberSeries_ReturnsExpectedSum()
    {
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(ParamEx.IsLessThan(10), 2)).Returns(3);

        var result = calculatorService.AddNumberSeries(1, 2);
        
        result.ShouldBe(3);
        calculatorService.VerifyAll();
    }
}