using RockHopper;
using RockHopper.Assertions;
using RockHopper.Mocking;
using TestBed.Classes;

namespace TestBed.Tests;

[Fixture(Class = typeof(TestClassFixture), Shared = typeof(TestSharedFixture))]
public class TestClass2
{
    private readonly CalculatorService2 _calculatorService = TestContext.Subject<CalculatorService2>();
    private readonly Mock<ICalculator> _calculator = TestContext.Mock<ICalculator>();
    private readonly TestClassFixture _fixture = TestContext.Fixture<TestClassFixture>();
    private readonly TestSharedFixture _fixture2 = TestContext.Fixture<TestSharedFixture>();
    private readonly TestAssemblyFixture _fixture3 = TestContext.Fixture<TestAssemblyFixture>();
    
    public TestClass2()
    {
        _fixture.DoSomething();
        _fixture2.DoSomething();
        _fixture3.DoSomething();
    }
    
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
    
    // [Test]
    // public async Task TwoNumbers_AddAsync_ReturnsSum()
    // {
    //     var result = await _calculatorService.AddAsync(10, 20);
    //     result.ShouldBe(20, "My test message.");
    // }
    
    [Test]
    public void TwoNumbers_Subtract_ReturnsDifference()
    {
        _calculator.Setup(c => c.Subtract(20, 10)).Returns(10).OccursOnce();
        
        var result = _calculatorService.SubtractNumbers(20, 10);
        
        result.ShouldBe(10);
    }
    
    /*[Test]
    public void TwoNumbers_Multiply_ReturnsProduct()
    {
        var result = _calculatorService.Multiply(2, 3);
        result.ShouldBe(6);
    }
    
    [Test]
    public void TwoNumbers_Divide_ReturnsQuotient()
    {
        var result = _calculatorService.Divide(4, 2);
        result.ShouldBe(2);
    }
    
    [Test]
    public void Test2()
    {
        //throw new Exception("Oops.");
    }
    
    [Test]
    public void Test3()
    {
        
    }

    [Test]
    public async Task Test4()
    {
        await Task.Delay(5);
        //throw new Exception("Oops");
    }*/
}