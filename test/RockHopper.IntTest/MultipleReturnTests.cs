using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;

namespace RockHopper.IntTest;

public class MultipleReturnTests
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<Calculator> _calculator = TestContext.Mock<Calculator>();
    
    [Test]
    public void SeriesOfNumbers_AddNumberSeries_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(1, 2)).Returns(3);
        _calculator.Setup(c => c.Add(3, 3)).Returns(6);
        _calculator.Setup(c => c.Add(6, 4)).Returns(10);
        _calculator.Setup(c => c.Add(10, 5)).Returns(15);

        var result = _calculatorService.AddNumberSeries(1, 2, 3, 4, 5);
        
        result.ShouldBe(15);
    }
}