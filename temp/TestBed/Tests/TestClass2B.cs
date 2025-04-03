using RockHopper;
using RockHopper.Assertions;
using RockHopper.Mocking;
using TestBed.Classes;

namespace TestBed.Tests;

public class TestClass2B
{
    private readonly CalculatorService2 _calculatorService = TestContext.Current.Subject<CalculatorService2>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();
    
    [Test]
    public void TwoNumbers_Add_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(10, 20)).Returns(30).OccursOnce();
        
        var result = _calculatorService.AddNumbers(10, 20);
        
        result.ShouldBe(30, "My test message.");
    }
    
    [Test]
    public void TwoNumbers_AddNumberSeries_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(1, 2)).Returns(3).OccursOnce();
        _calculator.Setup(c => c.Add(3, 3)).Returns(6).OccursOnce();
        _calculator.Setup(c => c.Add(6, 4)).Returns(10).OccursOnce();
        _calculator.Setup(c => c.Add(10, 5)).Returns(15).OccursOnce();
        //_calculator.Setup(c => c.Add(15, 6)).Returns(21).OccursOnce();
        
        var result = _calculatorService.AddNumberSeries(1, 2, 3, 4, 5);
        
        result.ShouldBe(15, "My test message.");
    }
}