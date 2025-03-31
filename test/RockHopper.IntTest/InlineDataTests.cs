using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;

namespace RockHopper.IntTest;

public class InlineDataTests
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<Calculator> _calculator = TestContext.Mock<Calculator>();

    [Test(InlineArgs = [1, 2, 3])]
    [Test(InlineArgs = [-1, -2, -3])]
    [Test(InlineArgs = [-1, 2, 1])]
    [Test(InlineArgs = [-1, 1, 0])]
    public void TwoNumbers_AddNumbers_ReturnsSum(int first, int second, int expectedResult)
    {
        _calculator.Setup(c => c.Add(first, second)).Returns(expectedResult);

        var result = _calculatorService.AddNumbers(first, second);
        
        result.ShouldBe(expectedResult);
    }
    
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [-1, -2, 1])]
    [Test(InlineArgs = [-1, 2, -3])]
    [Test(InlineArgs = [1, 1, 0])]
    public void TwoNumbers_SubtractNumbers_ReturnsDifference(int first, int second, int expectedResult)
    {
        _calculator.Setup(c => c.Subtract(first, second)).Returns(expectedResult);

        var result = _calculatorService.SubtractNumbers(first, second);
        
        result.ShouldBe(expectedResult);
    }
}