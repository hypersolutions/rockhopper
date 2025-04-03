using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;
// ReSharper disable ConvertConstructorToMemberInitializers - Check per test setup/teardown

namespace RockHopper.IntTest;

public class PerTestSetupTeardownTests : IDisposable
{
    private readonly CalculatorAltService _calculatorService = TestContext.Current.Subject<CalculatorAltService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();
    private readonly int _constructorCount;

    public PerTestSetupTeardownTests()
    {
        _constructorCount = 1;
    }
    
    [Test]
    public void TwoNumbers_AddNumbers_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(10, 20)).Returns(30);

        var result = _calculatorService.AddNumbers(10, 20);
        
        result.ShouldBe(30);
    }
    
    [Test]
    public void TwoNumbers_SubtractNumbers_ReturnsDifference()
    {
        _calculator.Setup(c => c.Subtract(30, 20)).Returns(10);

        var result = _calculatorService.SubtractNumbers(30, 20);
        
        result.ShouldBe(10);
    }

    public void Dispose()
    {
        _constructorCount.ShouldBe(1, "Check that each test only sets the counter once!");
    }
}