namespace RockHopper.TestSupport;

public class TextLogger
{
    public virtual void Log(string text)
    {
        Console.WriteLine(text);
    }
}