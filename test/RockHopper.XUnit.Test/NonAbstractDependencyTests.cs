using RockHopper.TestSupport;

namespace RockHopper.XUnit.Test;

public class NonAbstractDependencyTests
{
    [Fact]
    public void SentenceCaseText_Capitalize_LogsUppercaseText()
    {
        var textFormatterService = TestSubject.Create<TextFormatterService>();
        var textLogger = textFormatterService.GetMock<TextLogger>();
        textLogger.Method(l => l.Log("HELLO WORLD")).OccursOnce();

        textFormatterService.Capitalize("Hello world");
        
        textFormatterService.VerifyAll();
    }
}