namespace RockHopper.TestSupport;

public interface IIntConverter
{
    bool TryOutParse(string text, out int value);
    bool TryRefParse(string text, ref int value);
}