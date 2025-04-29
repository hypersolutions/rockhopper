namespace RockHopper.TestSupport;

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