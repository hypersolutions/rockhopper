using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;

namespace RockHopper.IntTest;

public class DataFromConfigurationTests
{
    private readonly CalculatorAltService _calculatorService = TestContext.Subject<CalculatorAltService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();
    private readonly int _firstNumber = TestContext.Configuration.Get<int>("TestData:X");
    private readonly int _secondNumber = TestContext.Configuration.Get<int>("TestData:Y");
    private readonly int _sumResult = TestContext.Configuration.Get<int>("TestData:Sum");
    private readonly int _differenceResult = TestContext.Configuration.Get<int>("TestData:Difference");

    public DataFromConfigurationTests()
    {
        _firstNumber.ShouldBeGreaterThan(0, "Check we have loaded the first number from config.");
        _secondNumber.ShouldBeGreaterThan(0, "Check we have loaded the second number from config.");
        _sumResult.ShouldBeGreaterThan(0, "Check we have loaded the sum from config.");
        _differenceResult.ShouldBeGreaterThan(0, "Check we have loaded the difference from config.");
    }
    
    [Test]
    public void TwoNumbers_AddNumbers_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(_firstNumber, _secondNumber)).Returns(_sumResult);

        var result = _calculatorService.AddNumbers(_firstNumber, _secondNumber);
        
        result.ShouldBe(_sumResult);
    }
    
    [Test]
    public void TwoNumbers_SubtractNumbers_ReturnsDifference()
    {
        _calculator.Setup(c => c.Subtract(_firstNumber, _secondNumber)).Returns(_differenceResult);

        var result = _calculatorService.SubtractNumbers(_firstNumber, _secondNumber);
        
        result.ShouldBe(_differenceResult);
    }
}