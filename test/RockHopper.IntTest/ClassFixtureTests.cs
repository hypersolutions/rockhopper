using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;

namespace RockHopper.IntTest;

[Fixture(Class = typeof(TwoNumbersClassFixture))]
public class ClassFixtureTests
{
    private readonly CalculatorAltService _calculatorService = TestContext.Current.Subject<CalculatorAltService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();
    private readonly TwoNumbersClassFixture _classFixture = TestContext.Current.Fixture<TwoNumbersClassFixture>();

    [Test]
    public void TwoFixtureNumbers_AddNumbers_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(_classFixture.FirstValue, _classFixture.SecondValue)).Returns(303);

        var result = _calculatorService.AddNumbers(_classFixture.FirstValue, _classFixture.SecondValue);
        
        result.ShouldBe(303);
    }
    
    [Test]
    public void RepeatTwoFixtureNumbers_AddNumbers_ReturnsSameSum()
    {
        _calculator.Setup(c => c.Add(_classFixture.FirstValue, _classFixture.SecondValue)).Returns(303);

        var result = _calculatorService.AddNumbers(_classFixture.FirstValue, _classFixture.SecondValue);
        
        result.ShouldBe(303);
    }
}