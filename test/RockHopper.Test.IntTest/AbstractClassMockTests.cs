using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.Test.IntTest.Support;

namespace RockHopper.Test.IntTest;

public class AbstractClassMockTests
{
    private readonly CalculatorService _calculatorService;
    private readonly Mock<Calculator> _calculator;

    public AbstractClassMockTests()
    {
        var testSubject = new TestSubject<CalculatorService>();
        _calculatorService = testSubject;
        _calculator = testSubject.GetMock<Calculator>();
    }
    
    [Test]
    public void TwoNumbers_AddNumbers_ReturnsSum()
    {
        _calculator.Function(c => c.Add(10, 20)).Returns(30);

        var result = _calculatorService.AddNumbers(10, 20);
        
        result.ShouldBe(30);
    }
    
    [Test]
    public void TwoNumbers_SubtractNumbers_ReturnsDifference()
    {
        _calculator.Function(c => c.Subtract(30, 20)).Returns(10);

        var result = _calculatorService.SubtractNumbers(30, 20);
        
        result.ShouldBe(10);
    }
}