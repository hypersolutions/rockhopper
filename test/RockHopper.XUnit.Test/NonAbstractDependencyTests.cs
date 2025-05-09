using RockHopper.TestSupport;

namespace RockHopper.XUnit.Test;

public class NonAbstractDependencyTests
{
    [Fact]
    public void SentenceCaseText_Capitalize_LogsUppercaseText()
    {
        var testSubject = new TestSubject<TextFormatterService>();
        TextFormatterService textFormatterService = testSubject;
        var textLogger = testSubject.GetMock<TextLogger>();
        textLogger.Method(l => l.Log("HELLO WORLD")).OccursOnce();

        textFormatterService.Capitalize("Hello world");
        
        testSubject.VerifyAll();
    }
}