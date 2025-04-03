using RockHopper;
using RockHopper.Assertions;
using RockHopper.Mocking;
using ClassLibrary1SourceProject;

namespace RockHopperScaleTest;

public class SubtractPositiveNumbersTests1
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests2
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests3
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests4
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests5
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests6
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests7
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests8
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests9
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests10
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests11
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests12
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests13
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests14
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests15
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests16
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests17
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests18
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests19
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests20
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests21
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests22
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests23
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests24
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests25
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests26
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests27
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests28
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests29
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests30
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests31
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests32
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests33
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests34
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests35
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests36
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests37
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests38
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests39
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests40
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests41
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests42
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests43
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests44
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests45
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests46
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests47
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests48
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests49
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests50
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [10, 9, 1])]
    [Test(InlineArgs = [9, 8, 1])]
    [Test(InlineArgs = [8, 7, 1])]
    [Test(InlineArgs = [7, 6, 1])]
    [Test(InlineArgs = [6, 5, 1])]
    [Test(InlineArgs = [5, 4, 1])]
    [Test(InlineArgs = [4, 3, 1])]
    [Test(InlineArgs = [3, 2, 1])]
    [Test(InlineArgs = [2, 1, 1])]
    [Test(InlineArgs = [1, 0, 1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
