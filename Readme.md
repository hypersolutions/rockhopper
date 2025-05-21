# RockHopper

Provides a simple way to build a test subject with its mock dependencies. Backed by the _Castle Core_ assembly for proxy generation,
this framework supports both constructor and property dependencies.

The mock framework supports strict mocking only. There is no support for loose mocks. This means that you _have_ to provide 
a matching mock setup for any calls made to mocks. This is **by design** to enforce deliberate enforcement of good test practices.

## Getting Started

You can install the NuGet package: TODO

Then as a simple example, you can use your favourite unit test framework and add the following code to test:

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
        var testSubject = new TestSubject<CalculatorService>();
        CalculatorService calculatorService = testSubject;
        var calculator = testSubject.GetMock<Calculator>();
        calculator.Function(c => c.Add(1, 2)).Returns(3);
        
        // Act
        var sum = calculatorService.AddNumbers(1, 2);
        
        // Assert
        Assert.Equal(3, sum);
    }
}
```

## Occurrences

By default, a setup of a mock will _expect_ a single call. This can be overriden by using the setup extensions:

```c#
textLogger.Method(l => l.Log("HELLO WORLD")).OccursAtLeast(10);
```


## Features

Explore [Deferred Returns](Readme.DeferredReturns.md)

Explore [Out & Ref Parameters](Readme.OutAndRefParameters.md)

Explore [Non-abstract Dependencies](Readme.NonAbstractClassDependencies.md)

Explore [Return Series](Readme.ReturnSeries.md)

## Useful

1. GitHub for project: https://github.com/hypersolutions/rockhopper/