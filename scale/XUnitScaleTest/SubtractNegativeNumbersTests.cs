using Xunit;
using Shouldly;
using NSubstitute;
using ClassLibrary1SourceProject;

namespace XUnitScaleTest;

public class SubtractNegativeNumbersTests1
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests1()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests2
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests2()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests3
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests3()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests4
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests4()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests5
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests5()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests6
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests6()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests7
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests7()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests8
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests8()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests9
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests9()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests10
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests10()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests11
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests11()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests12
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests12()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests13
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests13()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests14
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests14()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests15
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests15()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests16
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests16()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests17
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests17()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests18
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests18()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests19
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests19()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests20
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests20()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests21
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests21()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests22
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests22()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests23
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests23()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests24
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests24()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests25
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests25()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests26
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests26()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests27
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests27()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests28
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests28()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests29
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests29()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests30
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests30()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests31
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests31()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests32
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests32()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests33
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests33()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests34
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests34()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests35
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests35()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests36
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests36()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests37
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests37()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests38
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests38()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests39
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests39()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests40
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests40()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests41
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests41()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests42
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests42()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests43
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests43()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests44
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests44()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests45
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests45()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests46
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests46()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests47
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests47()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests48
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests48()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests49
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests49()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractNegativeNumbersTests50
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractNegativeNumbersTests50()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(-10, 9, -19)]
    [InlineData(-9, 8, -17)]
    [InlineData(-8, 7, -15)]
    [InlineData(-7, 6, -13)]
    [InlineData(-6, 5, -11)]
    [InlineData(-5, 4, -9)]
    [InlineData(-4, 3, -7)]
    [InlineData(-3, 2, -5)]
    [InlineData(-2, 1, -3)]
    [InlineData(-1, 0, -1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
