namespace RockHopper.TestSupport.Formatting;

public sealed class ReverseTextFormatter : ITextFormater
{
    public string Format(string text)
    {
        return text.Reverse().ToString()!;
    }
}