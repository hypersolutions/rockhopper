namespace RockHopper.TestSupport;

public sealed class TextFormatterService
{
    public TextLogger Logger { get; init; } = null!;
    
    public string Capitalize(string text)
    {
        var newText = text.ToUpper();
        Logger.Log(newText);
        return newText;
    }
}