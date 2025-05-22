using RockHopper.TestSupport.Formatting;

namespace RockHopper.XUnit.Test;

public class NonAbstractDependencyTests
{
    [Fact]
    public void SentenceCaseText_Capitalize_LogsUppercaseText()
    {
        var options = new TestSubjectCreateOptions { MockProperties = true };
        var textFormatterService = TestSubject.Create<TextFormatterService>(options);
        var textLogger = textFormatterService.GetMock<TextLogger>();
        textLogger.Method(l => l.Log("HELLO WORLD")).OccursOnce();

        textFormatterService.Capitalize("Hello world");
        
        textFormatterService.VerifyAll();
    }
}