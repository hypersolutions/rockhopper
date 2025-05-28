# Extensions

## Parameter Matching

There are built-in parameter matching factories such as _exact_ , _predicate_, _regex_ and _any_ matching but you can 
extend this for your own needs.

First create a class that extends the _ParameterMatcher_ and implements the methods:

```c#
internal sealed class LessThanParameterMatcher : ParameterMatcher
{
    private int _maxValue;
    
    public override bool IsMatch(object? actual)
    {
        return (int?)actual < _maxValue;
    }

    public override void SetValue(Delegate? predicate)
    {
        _maxValue = (int)predicate?.DynamicInvoke()!;
    }
}
```

The _SetValue_ is called during the setup to pass a _delegate_ with the value to use for comparing the incoming parameter
value when checking for a match as part of the _IsMatch_ call. This is your opportunity to determine if the value passed 
to the mock during the test, matches your rules and return _true_ if it does.

Now you need to expose this to your test methods so you can use it as part of your _mock_ setup. Create a static class:

```c#
public static class ParamEx
{
    [ParameterMatcher(typeof(LessThanParameterMatcher))]
    public static int IsLessThan(int maxValue)
    {
        return 0;
    }
}
```

The _attribute_ marks the helper method to know what matcher to invoke. The return value is arbitrary as this is to satisfy
the return type that will match you parameter. You can use it like:

```c#
[Fact]
public void ParamLessThanValue_AddNumberSeries_ReturnsExpectedSum()
{
    var calculatorService = TestSubject.Create<CalculatorService>();
    var calculator = calculatorService.GetMock<Calculator>();
    calculator.Function(c => c.Add(ParamEx.IsLessThan(10), 2)).Returns(3);

    var result = calculatorService.AddNumberSeries(1, 2);
    
    result.ShouldBe(3);
    calculatorService.VerifyAll();
}
```

So the above will accept any value for _x_ passed to the mock as long as it is less than 10 in this case.