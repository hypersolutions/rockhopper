using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;

namespace RockHopper.IntTest;

[Fixture(Shared = typeof(TwoNumbersSharedFixture))]
public class SharedFixtureTests1
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<Calculator> _calculator = TestContext.Mock<Calculator>();
    private readonly TwoNumbersSharedFixture _sharedFixture = TestContext.Fixture<TwoNumbersSharedFixture>();

    [Test]
    public void TwoFixtureNumbers_AddNumbers_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(_sharedFixture.FirstValue, _sharedFixture.SecondValue)).Returns(1003);

        var result = _calculatorService.AddNumbers(_sharedFixture.FirstValue, _sharedFixture.SecondValue);
        
        result.ShouldBe(1003);
        TwoNumbersSharedFixture.ConstructorCount.ShouldBe(
            1, "The constructor has been called more than once for a shared fixture!");
    }
    
    [Test]
    public void RepeatTwoFixtureNumbers_AddNumbers_ReturnsSameSum()
    {
        _calculator.Setup(c => c.Add(_sharedFixture.FirstValue, _sharedFixture.SecondValue)).Returns(1003);

        var result = _calculatorService.AddNumbers(_sharedFixture.FirstValue, _sharedFixture.SecondValue);
        
        result.ShouldBe(1003);
        TwoNumbersSharedFixture.ConstructorCount.ShouldBe(
            1, "The constructor has been called more than once for a shared fixture!");
    }
}

[Fixture(Shared = typeof(TwoNumbersSharedFixture))]
public class SharedFixtureTests2
{
    private readonly CalculatorAltService _calculatorService = TestContext.Subject<CalculatorAltService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();
    private readonly TwoNumbersSharedFixture _sharedFixture = TestContext.Fixture<TwoNumbersSharedFixture>();

    [Test]
    public void TwoFixtureNumbers_AddNumbers_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(_sharedFixture.FirstValue, _sharedFixture.SecondValue)).Returns(1003);

        var result = _calculatorService.AddNumbers(_sharedFixture.FirstValue, _sharedFixture.SecondValue);
        
        result.ShouldBe(1003);
        TwoNumbersSharedFixture.ConstructorCount.ShouldBe(
            1, "The constructor has been called more than once for a shared fixture!");
    }
    
    [Test]
    public void RepeatTwoFixtureNumbers_AddNumbers_ReturnsSameSum()
    {
        _calculator.Setup(c => c.Add(_sharedFixture.FirstValue, _sharedFixture.SecondValue)).Returns(1003);

        var result = _calculatorService.AddNumbers(_sharedFixture.FirstValue, _sharedFixture.SecondValue);
        
        result.ShouldBe(1003);
        TwoNumbersSharedFixture.ConstructorCount.ShouldBe(
            1, "The constructor has been called more than once for a shared fixture!");
    }
}