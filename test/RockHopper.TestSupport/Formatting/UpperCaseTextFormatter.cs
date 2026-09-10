namespace RockHopper.TestSupport.Formatting;

public sealed class UpperCaseTextFormatter : ITextFormater
{
    public string Format(string text)
    {
        return text.ToUpper();
    }
}