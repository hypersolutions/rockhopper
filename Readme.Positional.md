# Positional

## Parameter Matching

In rare cases, you might have the same interface injected into the constructor multiple times. To support this, there is
support for positional parameters. This process _may_ work for combined parameter and property injection but is designed
primarily for constructor parameters.

Given an interface that is used to format some text:


```c#
public interface ITextFormater
{
    string Format(string text);
}
```

and there are two implementations:

```c#
public sealed class UpperCaseTextFormatter : ITextFormater
{
    public string Format(string text)
    {
        return text.ToUpper();
    }
}

public sealed class ReverseTextFormatter : ITextFormater
{
    public string Format(string text)
    {
        return text.Reverse().ToString()!;
    }
}
```

You may have a service that provides wrapping those operations:

```c#
public sealed class AltTextFormatterService
{
    private readonly ITextFormater _upperCaseTextFormatter;
    private readonly ITextFormater _reverseTextFormatter;

    public AltTextFormatterService(ITextFormater upperCaseTextFormatter, ITextFormater reverseTextFormatter)
    {
        _upperCaseTextFormatter = upperCaseTextFormatter;
        _reverseTextFormatter = reverseTextFormatter;
    }

    public string Format(string text)
    {
        var newText = _upperCaseTextFormatter.Format(text);
        return _reverseTextFormatter.Format(newText);
    }
}
```

To test this, you can use the _GetMockAt_ method instead of the _GetMock_ method. It accepts an enum of positional values
such that:

```c#
[Fact]
public void CtorHasSameType_GetMock_ReturnsDifferentMockInstanceForEach()
{
    var textFormatterService = TestSubject.Create<AltTextFormatterService>();
    
    var formater1 = textFormatterService.GetMockAt<ITextFormater>(MockIndexTypes.First);
    var formater2 = textFormatterService.GetMockAt<ITextFormater>(MockIndexTypes.Second);
    
    formater1.ShouldNotBe(formater2);
}
```