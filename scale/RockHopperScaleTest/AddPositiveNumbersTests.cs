using RockHopper;
using RockHopper.Assertions;
using RockHopper.Mocking;
using ClassLibrary1SourceProject;

namespace RockHopperScaleTest;

public class AddPositiveNumbersTests1
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests2
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests3
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests4
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests5
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests6
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests7
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests8
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests9
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests10
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests11
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests12
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests13
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests14
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests15
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests16
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests17
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests18
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests19
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests20
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests21
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests22
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests23
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests24
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests25
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests26
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests27
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests28
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests29
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests30
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests31
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests32
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests33
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests34
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests35
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests36
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests37
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests38
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests39
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests40
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests41
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests42
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests43
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests44
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests45
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests46
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests47
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests48
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests49
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests50
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();

    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, 2, 2])]
    [Test(InlineArgs = [1, 3, 4])]
    [Test(InlineArgs = [2, 4, 6])]
    [Test(InlineArgs = [3, 5, 8])]
    [Test(InlineArgs = [4, 6, 10])]
    [Test(InlineArgs = [5, 7, 12])]
    [Test(InlineArgs = [6, 8, 14])]
    [Test(InlineArgs = [7, 9, 16])]
    [Test(InlineArgs = [8, 10, 18])]
    [Test(InlineArgs = [9, 11, 20])]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
