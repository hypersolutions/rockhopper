using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;

namespace RockHopper.IntTest;

public class AssemblyFixtureTests1
{
    private readonly CalculatorService _calculatorService = TestContext.Current.Subject<CalculatorService>();
    private readonly Mock<Calculator> _calculator = TestContext.Current.Mock<Calculator>();
    private readonly TwoNumbersAssemblyFixture _sharedFixture = TestContext.Current.Fixture<TwoNumbersAssemblyFixture>();

    [Test]
    public void TwoFixtureNumbers_AddNumbers_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(_sharedFixture.FirstValue, _sharedFixture.SecondValue)).Returns(10003);

        var result = _calculatorService.AddNumbers(_sharedFixture.FirstValue, _sharedFixture.SecondValue);
        
        result.ShouldBe(10003);
        TwoNumbersSharedFixture.ConstructorCount.ShouldBe(
            1, "The constructor has been called more than once for an assembly fixture!");
    }
    
    [Test]
    public void RepeatTwoFixtureNumbers_AddNumbers_ReturnsSameSum()
    {
        _calculator.Setup(c => c.Add(_sharedFixture.FirstValue, _sharedFixture.SecondValue)).Returns(10003);

        var result = _calculatorService.AddNumbers(_sharedFixture.FirstValue, _sharedFixture.SecondValue);
        
        result.ShouldBe(10003);
        TwoNumbersSharedFixture.ConstructorCount.ShouldBe(
            1, "The constructor has been called more than once for an assembly fixture!");
    }
}

public class AssemblyFixtureTests2
{
    private readonly CalculatorAltService _calculatorService = TestContext.Current.Subject<CalculatorAltService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();
    private readonly TwoNumbersAssemblyFixture _sharedFixture = TestContext.Current.Fixture<TwoNumbersAssemblyFixture>();

    [Test]
    public void TwoFixtureNumbers_AddNumbers_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(_sharedFixture.FirstValue, _sharedFixture.SecondValue)).Returns(10003);

        var result = _calculatorService.AddNumbers(_sharedFixture.FirstValue, _sharedFixture.SecondValue);
        
        result.ShouldBe(10003);
        TwoNumbersSharedFixture.ConstructorCount.ShouldBe(
            1, "The constructor has been called more than once for an assembly fixture!");
    }
    
    [Test]
    public void RepeatTwoFixtureNumbers_AddNumbers_ReturnsSameSum()
    {
        _calculator.Setup(c => c.Add(_sharedFixture.FirstValue, _sharedFixture.SecondValue)).Returns(10003);

        var result = _calculatorService.AddNumbers(_sharedFixture.FirstValue, _sharedFixture.SecondValue);
        
        result.ShouldBe(10003);
        TwoNumbersSharedFixture.ConstructorCount.ShouldBe(
            1, "The constructor has been called more than once for an assembly fixture!");
    }
}