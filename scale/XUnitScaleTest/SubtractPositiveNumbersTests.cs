using Xunit;
using Shouldly;
using NSubstitute;
using ClassLibrary1SourceProject;

namespace XUnitScaleTest;

public class SubtractPositiveNumbersTests1
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests1()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests2
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests2()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests3
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests3()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests4
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests4()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests5
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests5()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests6
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests6()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests7
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests7()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests8
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests8()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests9
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests9()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests10
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests10()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests11
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests11()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests12
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests12()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests13
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests13()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests14
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests14()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests15
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests15()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests16
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests16()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests17
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests17()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests18
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests18()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests19
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests19()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests20
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests20()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests21
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests21()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests22
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests22()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests23
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests23()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests24
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests24()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests25
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests25()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests26
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests26()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests27
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests27()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests28
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests28()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests29
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests29()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests30
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests30()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests31
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests31()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests32
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests32()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests33
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests33()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests34
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests34()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests35
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests35()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests36
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests36()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests37
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests37()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests38
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests38()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests39
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests39()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests40
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests40()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests41
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests41()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests42
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests42()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests43
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests43()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests44
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests44()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests45
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests45()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests46
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests46()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests47
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests47()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests48
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests48()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests49
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests49()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class SubtractPositiveNumbersTests50
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

   public SubtractPositiveNumbersTests50()
    {
        _calculator = Substitute.For<ICalculator>();
        _calculatorService = new CalculatorService(_calculator);
    }

    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers1_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers2_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers3_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers4_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(10, 9, 1)]
    [InlineData(9, 8, 1)]
    [InlineData(8, 7, 1)]
    [InlineData(7, 6, 1)]
    [InlineData(6, 5, 1)]
    [InlineData(5, 4, 1)]
    [InlineData(4, 3, 1)]
    [InlineData(3, 2, 1)]
    [InlineData(2, 1, 1)]
    [InlineData(1, 0, 1)]
    public void SubtractPositiveNumbers5_SubtractNumbers_ReturnDifference(int x, int y, int r)
    {
        _calculator.Subtract(x, y).Returns(r);

        var result = _calculatorService.SubtractNumbers(x, y);

        result.ShouldBe(r);
    }
}
