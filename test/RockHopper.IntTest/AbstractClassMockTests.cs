using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;

namespace RockHopper.IntTest;

public class AbstractClassMockTests
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<Calculator> _calculator = TestContext.Mock<Calculator>();

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