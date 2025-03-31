using System.Collections;
using RockHopper;
using RockHopper.Assertions;
using RockHopper.Mocking;
using TestBed.Classes;

namespace TestBed.Tests;

[Fixture(Class = typeof(TestClassFixture), Shared = typeof(TestSharedFixture))]
public class TestClass1
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<Calculator> _calculator = TestContext.Mock<Calculator>();
    private readonly TestClassFixture _fixture = TestContext.Fixture<TestClassFixture>();
    private readonly TestSharedFixture _fixture2 = TestContext.Fixture<TestSharedFixture>();
    private readonly ITestSetup _testSetup = TestContext.Service<ITestSetup>();

    public TestClass1()
    {
        _fixture.DoSomething();
        _fixture2.DoSomething();
        _testSetup.Run();
    }
    
    [Test(Skip = "Test the skip")]
    public void SkippedTwoNumbers_Add_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(10, 20)).Returns(30).OccursOnce();
        
        var result = _calculatorService.AddNumbers(10, 20);
        
        result.ShouldBe(30, "My test message.");
    }
    
    [Test]
    public void TwoNumbers_Add_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(10, 20)).Returns(30).OccursOnce();

        TestContext.TestOutput.WriteLine("Let's add some numbers!");
        
        var result = _calculatorService.AddNumbers(10, 20);
        
        result.ShouldBe(30, "My test message.");
    }
    
    [Test(InlineArgs = [1, 2, 3])]
    [Test(InlineArgs = [-1, -2, -3])]
    [Test(InlineArgs = [-1, 2, 1])]
    [Test(InlineArgs = [-1, 1, 0])]
    public void TwoNumbersWithArgs_Add_ReturnsSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r).OccursOnce();
        
        var result = _calculatorService.AddNumbers(x, y);
        
        result.ShouldBe(r, "My test message.");
    }
    
    [Test(ClassArgs = typeof(AddData))]
    [Test(MemberArgs = nameof(Data))]
    [Test(InlineArgs = [100, 200, 300])]
    [Test(InlineArgs = [100, 200, 300], ClassArgs = typeof(AddData))]
    public void TwoNumbersWithVariousArgs_Add_ReturnsSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r).OccursOnce();
        
        var result = _calculatorService.AddNumbers(x, y);
        
        result.ShouldBe(r, "My test message.");
    }
    
    [Test(ClassArgs = typeof(AddDataNotEnumerable))]
    [Test(MemberArgs = nameof(DataNotEnumerable))]
    public void TwoNumbersWithInvalidArgData_Add_ReturnsSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r).OccursOnce();
        
        var result = _calculatorService.AddNumbers(x, y);
        
        result.ShouldBe(r, "My test message.");
    }
    
    private sealed class AddData : IEnumerable<(int, int, int)>
    {
        public IEnumerator<(int, int, int)> GetEnumerator()
        {
            yield return (1, 2, 3);
            yield return (-1, -2, -3);
            yield return (-1, 2, 1);
            yield return (1, -1, 0);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    private sealed class AddDataNotEnumerable;

    public static IEnumerable<(int X, int Y, int R)> Data =>
        new List<(int X, int Y, int R)>
        {
            new ( 1, 2, 3 ),
            new ( -1, -2, -3 ),
            new ( -1, 2, 1 ),
            new ( -1, 1, 0 )
        };

    public static object DataNotEnumerable => new { };
    
    [Test]
    public void TwoNumbers_AddNumberSeries_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(1, 2)).Returns(3);//.OccursOnce();
        _calculator.Setup(c => c.Add(3, 3)).Returns(6).OccursOnce();
        _calculator.Setup(c => c.Add(6, 4)).Returns(10);//.OccursOnce();
        _calculator.Setup(c => c.Add(10, 5)).Returns(15).OccursOnce();
        //_calculator.Setup(c => c.Add(15, 6)).Returns(21);//.OccursOnce();

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