namespace RockHopper.TestSupport.Formatting;

public class TextLogger
{
    public virtual void Log(string text)
    {
        Console.WriteLine(text);
    }
}