using NUnit.Framework;
using RockHopper.TestSupport;

namespace RockHopper.NUnit.Test;

public class NonAbstractDependencyTests
{
    [Test]
    public void SentenceCaseText_Capitalize_LogsUppercaseText()
    {
        var testSubject = new TestSubject<TextFormatterService>();
        TextFormatterService textFormatterService = testSubject;
        var textLogger = testSubject.GetMock<TextLogger>();
        textLogger.Setup(l => l.Log("HELLO WORLD")).OccursOnce();

        textFormatterService.Capitalize("Hello world");
        
        testSubject.VerifyAll();
    }
}