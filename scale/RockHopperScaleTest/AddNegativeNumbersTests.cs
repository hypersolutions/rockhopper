using RockHopper;
using RockHopper.Assertions;
using RockHopper.Mocking;
using ClassLibrary1SourceProject;

namespace RockHopperScaleTest;

public class AddNegativeNumbersTests1
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests2
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests3
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests4
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests5
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests6
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests7
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests8
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests9
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests10
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests11
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests12
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests13
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests14
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests15
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests16
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests17
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests18
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests19
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests20
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests21
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests22
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests23
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests24
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests25
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests26
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests27
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests28
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests29
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests30
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests31
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests32
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests33
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests34
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests35
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests36
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests37
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests38
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests39
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests40
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests41
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests42
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests43
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests44
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests45
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests46
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests47
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests48
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests49
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests50
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();

    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Test(InlineArgs = [0, -2, -2])]
    [Test(InlineArgs = [-1, -3, -4])]
    [Test(InlineArgs = [-2, -4, -6])]
    [Test(InlineArgs = [-3, -5, -8])]
    [Test(InlineArgs = [-4, -6, -10])]
    [Test(InlineArgs = [-5, -7, -12])]
    [Test(InlineArgs = [-6, -8, -14])]
    [Test(InlineArgs = [-7, -9, -16])]
    [Test(InlineArgs = [-8, -10, -18])]
    [Test(InlineArgs = [-9, -11, -20])]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
