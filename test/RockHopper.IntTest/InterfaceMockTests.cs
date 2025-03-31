using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;

namespace RockHopper.IntTest;

public class InterfaceMockTests
{
    private readonly CalculatorAltService _calculatorService = TestContext.Subject<CalculatorAltService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test]
    public void TwoNumbers_AddNumbers_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(10, 20)).Returns(30);

        var result = _calculatorService.AddNumbers(10, 20);
        
        result.ShouldBe(30);
    }
    
    [Test]
    public void TwoNumbers_SubtractNumbers_ReturnsDifference()
    {
        _calculator.Setup(c => c.Subtract(30, 20)).Returns(10);

        var result = _calculatorService.SubtractNumbers(30, 20);
        
        result.ShouldBe(10);
    }
}