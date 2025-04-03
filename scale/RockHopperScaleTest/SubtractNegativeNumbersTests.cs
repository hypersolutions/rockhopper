using RockHopper;
using RockHopper.Assertions;
using RockHopper.Mocking;
using ClassLibrary1SourceProject;

namespace RockHopperScaleTest;

public class SubtractNegativeNumbersTests1
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests2
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests3
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests4
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests5
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests6
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests7
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests8
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests9
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests10
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests11
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests12
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests13
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests14
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests15
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests16
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests17
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests18
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests19
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests20
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests21
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests22
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests23
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests24
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests25
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests26
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests27
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests28
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests29
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests30
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests31
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests32
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests33
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests34
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests35
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests36
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests37
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests38
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests39
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests40
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests41
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests42
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests43
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests44
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests45
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests46
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests47
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests48
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests49
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests50
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [-10, 9, -19])]
    [Test(InlineArgs = [-9, 8, -17])]
    [Test(InlineArgs = [-8, 7, -15])]
    [Test(InlineArgs = [-7, 6, -13])]
    [Test(InlineArgs = [-6, 5, -11])]
    [Test(InlineArgs = [-5, 4, -9])]
    [Test(InlineArgs = [-4, 3, -7])]
    [Test(InlineArgs = [-3, 2, -5])]
    [Test(InlineArgs = [-2, 1, -3])]
    [Test(InlineArgs = [-1, 0, -1])]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Setup(c => c.Subtract(x, y)).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
