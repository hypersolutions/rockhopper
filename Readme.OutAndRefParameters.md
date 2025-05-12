# Out & Ref Parameters

Both _out_ and _ref_ parameters are supported. Firstly _out_ parameters are as simple as defining a variable and assigning 
it the desired value and passing it as an _out_ parameter in the mock setup:

```c#
[Fact]
public void ValidIntAsString_GetValue_ReturnsIntResult()
{
    var value = 123;
    _intConverter.Function(c => c.TryParse("123", out value)).Returns(true);

    var result = _converterService.GetValue("123");

    result.ShouldBe(123);
}
```

The _ref_ parameter works in very much the way as the _out_ parameter:

```c#
[Fact]
public void ValidIntAsStringWithBaseValue_GetValue_ReturnsIntResult()
{
    var value = 123;
    _intConverter.Function(c => c.TryRefParse("123", ref value)).Returns(true);

    var result = _converterService.GetValue("123", 100);

    result.ShouldBe(223);
}
```

**Both** of the above use a _ConverterService_ with a _IIntConverter_ dependency.