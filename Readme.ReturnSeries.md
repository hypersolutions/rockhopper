﻿# Return Series

If you have a mock that is called multiple times, you can provide a series of values to return. Every time the mock is called 
with matching parameters, it will return the next value for the mock. Once you have reached the last return value, any further calls
will throw a _MockException_:

```c#
[Fact]
public void SequentialNumbers_AddNumberSeries_ReturnsTotal()
{
    var calculatorService = TestSubject.Create<CalculatorService>();
    var calculator = calculatorService.GetMock<Calculator>();
    calculator.Function(c => c.Add(Param.IsAny<int>(), Param.IsAny<int>())).Returns(3, 6, 10, 15);

    var result = calculatorService.AddNumberSeries(1, 2, 3, 4, 5);
    
    result.ShouldBe(15);
}
```

**Note** that calling VerifyAll:

```c#
calculatorService.VerifyAll();
```

will reset the _visits_ under the hood so you can restart using the series again. This is by-design to support test scenarios
where retesting data during a test is required.