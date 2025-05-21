# Non-abstract Class Dependencies

As the underlying Castle core framework will provide proxies of concrete classes and allow for intercepting calls to 
virtual methods, this framework will support this too.

Given:

```c#
public class TextLogger
{
    public virtual void Log(string text)
    {
        Console.WriteLine(text);
    }
}

public sealed class TextFormatterService
{
    private readonly TextLogger _textLogger;

    public TextFormatterService(TextLogger textLogger)
    {
        _textLogger = textLogger;
    }
    
    public string Capitalize(string text)
    {
        var newText = text.ToUpper();
        _textLogger.Log(newText);
        return newText;
    }
}
```

Then you can provide a setup for any virtual method defined on the dependency as normal:

```c#
[Fact]
public void SentenceCaseText_Capitalize_LogsUppercaseText()
{
    var textFormatterService = TestSubject.Create<TextFormatterService>();
    var textLogger = textFormatterService.GetMock<TextLogger>();
    textLogger.Method(l => l.Log("HELLO WORLD")).OccursOnce();

    textFormatterService.Capitalize("Hello world");
    
    textFormatterService.VerifyAll();
}
```
