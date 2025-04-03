using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;

namespace RockHopper.IntTest;

public class MockThrowsExceptionTests
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<Calculator> _calculator = TestContext.Current.Mock<Calculator>();

    [Test]
    public void TwoNegativeNumbers_AddNumbers_ThrowsArgumentException()
    {
        _calculator.Setup(c => c.Add(-30, -20)).Throws(new ArgumentException("Negative numbers not allowed."));

        var exception = Should.Throw<ArgumentException>(() => _calculatorService.AddNumbers(-30, -20));
        
        exception.Message.ShouldBe("Negative numbers not allowed.");
    }
    
    [Test]
    public void TwoNegativeNumbers_AddNumbers_ThrowsGenericArgumentException()
    {
        _calculator.Setup(c => c.Add(-30, -20)).Throws<ArgumentException>();

        Should.Throw<ArgumentException>(() => _calculatorService.AddNumbers(-30, -20));
    }
}