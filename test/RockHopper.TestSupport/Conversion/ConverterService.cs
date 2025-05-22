namespace RockHopper.TestSupport.Conversion;

public class ConverterService
{
    private readonly IIntConverter _converter;

    public ConverterService(IIntConverter converter)
    {
        _converter = converter;
    }

    public int GetValue(string text)
    {
        return _converter.TryOutParse(text, out var value) ? value : -1;
    }
    
    public int GetValue(string text, int baseValue)
    {
        var value = 0;
        value = _converter.TryRefParse(text, ref value) ? value : -1;
        value += baseValue;
        return value;
    }
}