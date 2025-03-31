using Xunit;
using Shouldly;
using NSubstitute;
using ClassLibrary1SourceProject;

namespace XUnitScaleTest;

public class AddNegativeNumbersTests1
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests1()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests2
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests2()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests3
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests3()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests4
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests4()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests5
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests5()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests6
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests6()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests7
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests7()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests8
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests8()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests9
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests9()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests10
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests10()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests11
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests11()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests12
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests12()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests13
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests13()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests14
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests14()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests15
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests15()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests16
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests16()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests17
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests17()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests18
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests18()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests19
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests19()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests20
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests20()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests21
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests21()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests22
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests22()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests23
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests23()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests24
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests24()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests25
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests25()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests26
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests26()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests27
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests27()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests28
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests28()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests29
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests29()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests30
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests30()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests31
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests31()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests32
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests32()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests33
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests33()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests34
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests34()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests35
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests35()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests36
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests36()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests37
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests37()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests38
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests38()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests39
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests39()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests40
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests40()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests41
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests41()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests42
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests42()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests43
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests43()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests44
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests44()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests45
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests45()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests46
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests46()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests47
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests47()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests48
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests48()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests49
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests49()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddNegativeNumbersTests50
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public AddNegativeNumbersTests50()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, -2, -2)]
    [InlineData(-1, -3, -4)]
    [InlineData(-2, -4, -6)]
    [InlineData(-3, -5, -8)]
    [InlineData(-4, -6, -10)]
    [InlineData(-5, -7, -12)]
    [InlineData(-6, -8, -14)]
    [InlineData(-7, -9, -16)]
    [InlineData(-8, -10, -18)]
    [InlineData(-9, -11, -20)]
    public void TwoNegativeNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
