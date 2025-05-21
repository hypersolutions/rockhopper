# RockHopper

Provides a simple way to build a test subject with its mock dependencies. Backed by the _Castle Core_ assembly for proxy generation,
this framework supports both constructor and property dependencies.

The mock framework supports strict mocking only. There is no support for loose mocks. This means that you _have_ to provide
a matching mock setup for any calls made to mocks. This is **by design** to enforce deliberate enforcement of good test practices.

## Getting Started

For a simple example, you can use your favourite unit test framework and add the following code to test:

```c#
public abstract class Calculator
{
    public abstract int Add(int x, int y);
}

public sealed class CalculatorService
{
    private readonly Calculator _calculator;

    public CalculatorService(Calculator calculator)
    {
        _calculator = calculator;
    }

    public int AddNumbers(int x, int y)
    {
        return AddNumberSeries(x, y);
    }
}
```

and then write a test (using XUnit for example):

```c#
public class CalculatorServiceTests
{
    [Fact]
    public void TwoNumbers_AddNumbers_ReturnsSum()
    {
        // Arrange
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(1, 2)).Returns(3);
        
        // Act
        var sum = calculatorService.AddNumbers(1, 2);
        
        // Assert
        Assert.Equal(3, sum);
    }
}
```

## More

1. GitHub for project: https://github.com/hypersolutions/rockhopper/