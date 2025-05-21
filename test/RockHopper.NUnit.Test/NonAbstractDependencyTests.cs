using NUnit.Framework;
using RockHopper.TestSupport;

namespace RockHopper.NUnit.Test;

public class NonAbstractDependencyTests
{
    [Test]
    public void SentenceCaseText_Capitalize_LogsUppercaseText()
    {
        var textFormatterService = TestSubject.Create<TextFormatterService>();
        var textLogger = textFormatterService.GetMock<TextLogger>();
        textLogger.Method(l => l.Log("HELLO WORLD")).OccursOnce();

        textFormatterService.Capitalize("Hello world");
        
        textFormatterService.VerifyAll();
    }
}