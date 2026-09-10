namespace RockHopper.TestSupport.Formatting;

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