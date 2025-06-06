# RockHopper

Provides a simple way to build a test subject with its mock dependencies. Backed by the _Castle Core_ assembly for proxy generation,
this framework supports both constructor and property dependencies.

The mock framework supports strict mocking only. There is no support for loose mocks. This means that you _have_ to provide 
a matching mock setup for any calls made to mocks. This is **by design** for deliberate enforcement of good test practices.

## Status

![Build](https://img.shields.io/github/actions/workflow/status/hypersolutions/rockhopper/build-and-test.yml)![NuGet Version](https://img.shields.io/nuget/v/RockHopper)
![Stars](https://img.shields.io/github/stars/hypersolutions/rockhopper)![Closed Issues](https://img.shields.io/github/issues-closed-raw/hypersolutions/rockhopper)

## Getting Started

You can find this packages via NuGet:

[**RockHopper**](https://www.nuget.org/packages/RockHopper)

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
        return _calculator.Add(x, y);
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

## Occurrences

By default, a setup of a mock will _expect_ a single call. This can be overriden by using the setup extensions:

```c#
textLogger.Method(l => l.Log("Hello World")).OccursAtLeast(10);
```

## Features

Explore [Deferred Returns](Readme.DeferredReturns.md)

Explore [Async Returns](Readme.AsyncReturns.md)

Explore [Out & Ref Parameters](Readme.OutAndRefParameters.md)

Explore [Non-abstract Dependencies](Readme.NonAbstractClassDependencies.md)

Explore [Return Series](Readme.ReturnSeries.md)

Explore [Extensions](Readme.Extensions.md)

## Useful

1. GitHub for project: https://github.com/hypersolutions/rockhopper/