using Xunit;
using Shouldly;
using NSubstitute;
using ClassLibrary1SourceProject;

namespace XUnitScaleTest;

public class AddPositiveNumbersTests1
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests1()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests2
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests2()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests3
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests3()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests4
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests4()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests5
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests5()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests6
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests6()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests7
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests7()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests8
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests8()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests9
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests9()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests10
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests10()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests11
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests11()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests12
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests12()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests13
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests13()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests14
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests14()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests15
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests15()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests16
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests16()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests17
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests17()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests18
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests18()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests19
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests19()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests20
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests20()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests21
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests21()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests22
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests22()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests23
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests23()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests24
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests24()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests25
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests25()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests26
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests26()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests27
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests27()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests28
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests28()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests29
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests29()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests30
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests30()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests31
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests31()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests32
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests32()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests33
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests33()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests34
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests34()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests35
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests35()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests36
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests36()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests37
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests37()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests38
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests38()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests39
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests39()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests40
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests40()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests41
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests41()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests42
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests42()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests43
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests43()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests44
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests44()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests45
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests45()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests46
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests46()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests47
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests47()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests48
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests48()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests49
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests49()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
public class AddPositiveNumbersTests50
{
    private readonly CalculatorService _calculatorService;
    private readonly ICalculator _calculator;

    public AddPositiveNumbersTests50()
     {
         _calculator = Substitute.For<ICalculator>();
         _calculatorService = new CalculatorService(_calculator);
     }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers1_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers2_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers3_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers4_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(1, 3, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(3, 5, 8)]
    [InlineData(4, 6, 10)]
    [InlineData(5, 7, 12)]
    [InlineData(6, 8, 14)]
    [InlineData(7, 9, 16)]
    [InlineData(8, 10, 18)]
    [InlineData(9, 11, 20)]
    public void TwoPositiveNumbers5_AddNumbers_ReturnSum(int x, int y, int r)
    {
        _calculator.Add(x, y).Returns(r);

        var result = _calculatorService.AddNumbers(x, y);

        result.ShouldBe(r);
    }
}
