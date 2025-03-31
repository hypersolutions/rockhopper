# Quick Start

The following will get a simple test project up and running with a basic set of tests.

First create a new console app and install the NuGet package: _RockHopper_.

Replace the contents of the _Program.cs_ with:

```c#
using RockHopper;

var builder = RockHopperTestApplicationBuilder
    .CreateBuilder(args)
    .AddTestingFramework<Program>();

using var testApplication = await builder.BuildAsync();
_ = await testApplication.RunAsync();
```

Next create a new interface called _ICalculator_ and add the following contents:

```c#
public interface ICalculator
{
    int AddNumbers(int x, int y);
}
```

Then create a new class called _CalculatorService_ and add the following contents:

```c#
public sealed class CalculatorService
{
    private readonly ICalculator _calculator;

    public CalculatorService(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public int AddNumbers(int x, int y) => _calculator.Add(x, y);
}
```

Add a new test class called CalculatorServiceTests and add the following:

```c#
public class TestClass1
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();
    
    [Test]
    public void TwoNumbers_Add_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(10, 20)).Returns(30);

        var result = _calculatorService.AddNumbers(10, 20);
        
        result.ShouldBe(30);
    }
    
    [Test(InlineArgs = [1, 2, 3])]
    [Test(InlineArgs = [-1, -2, -3])]
    [Test(InlineArgs = [-1, 2, 1])]
    [Test(InlineArgs = [-1, 1, 0])]
    public void TwoNumbersWithArgs_Add_ReturnsSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r);
        
        var result = _calculatorService.AddNumbers(x, y);
        
        result.ShouldBe(r);
    }
```

Finally run the console app.
