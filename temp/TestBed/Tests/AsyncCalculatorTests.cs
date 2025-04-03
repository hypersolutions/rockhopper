using System.Collections;
using RockHopper;
using RockHopper.Assertions;
using RockHopper.Mocking;
using TestBed.Classes;

namespace TestBed.Tests;

public class AsyncCalculatorTests
{
    private readonly AsyncCalculatorService _calculatorService = TestContext.Current.Subject<AsyncCalculatorService>();
    private readonly Mock<ICalculator> _calculator = TestContext.Current.Mock<ICalculator>();
    
    [Test(Skip = "Test the skip")]
    public async Task SkippedTwoNumbers_AddNumbersAsync_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(10, 20)).Returns(30).OccursOnce();
        
        var result = await _calculatorService.AddNumbersAsync(10, 20);
        
        result.ShouldBe(30, "My test message.");
    }
    
    [Test(Description = "Adds two numbers together")]
    public async Task TwoNumbers_AddNumbersAsync_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(10, 20)).Returns(30).OccursOnce();
        
        var result = await _calculatorService.AddNumbersAsync(10, 20);
        
        result.ShouldBe(30, "My test message.");
    }
    
    [Test(Description = "Adds two numbers together loaded from config")]
    public async Task TwoNumbersFromConfig_AddNumbersAsync_ReturnsSum()
    {
        var x = TestContext.Current.GetConfig<int>("TestData:X");
        var y = TestContext.Current.GetConfig<int>("TestData:Y");
        var r = TestContext.Current.GetConfig<int>("TestData:R");
        _calculator.Setup(c => c.Add(x, y)).Returns(r).OccursOnce();
        
        var result = await _calculatorService.AddNumbersAsync(x, y);
        
        result.ShouldBe(r, "Failed to add numbers from config.");
        
        x.ShouldBe(120, "Config X number did not matched expected.");
        y.ShouldBe(30, "Config Y number did not matched expected.");
        r.ShouldBe(150, "Config R number did not matched expected.");
    }
    
    [Test(InlineArgs = [1, 2, 3])]
    [Test(InlineArgs = [-1, -2, -3])]
    [Test(InlineArgs = [-1, 2, 1])]
    [Test(InlineArgs = [-1, 1, 0])]
    public async Task TwoNumbersWithArgs_AddNumbersAsync_ReturnsSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r).OccursOnce();
        
        var result = await _calculatorService.AddNumbersAsync(x, y);
        
        result.ShouldBe(r, "My test message.");
    }
    
    [Test(ClassArgs = typeof(AddData))]
    [Test(MemberArgs = nameof(Data))]
    [Test(InlineArgs = [100, 200, 300])]
    [Test(InlineArgs = [100, 200, 300], ClassArgs = typeof(AddData))]
    public async Task TwoNumbersWithVariousArgs_AddNumbersAsync_ReturnsSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r).OccursOnce();
        
        var result = await _calculatorService.AddNumbersAsync(x, y);
        
        result.ShouldBe(r, "My test message.");
    }
    
    [Test(ClassArgs = typeof(AddDataNotEnumerable))]
    [Test(MemberArgs = nameof(DataNotEnumerable))]
    public async Task TwoNumbersWithInvalidArgData_Add_ReturnsSum(int x, int y, int r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns(r).OccursOnce();
        
        var result = await _calculatorService.AddNumbersAsync(x, y);
        
        result.ShouldBe(r, "My test message.");
    }
    
    [Test(ClassArgs = typeof(AddData))]
    public async Task TwoNumbersWithInvalidArgDataType_Add_ReturnsSum(int x, int y, double r)
    {
        _calculator.Setup(c => c.Add(x, y)).Returns((int)r).OccursOnce();
        await Task.Delay(1, TestContext.Current.CancellationToken); // Use cancellation token
        
        var result = await _calculatorService.AddNumbersAsync(x, y);
        
        result.ShouldBe((int)r, "My test message.");
    }

    private sealed class AddData : IEnumerable<(int X, int Y, int R)>
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
    public async Task TwoNumbers_AddNumberSeriesAsync_ReturnsSum()
    {
        _calculator.Setup(c => c.Add(1, 2)).Returns(3);//.OccursOnce();
        _calculator.Setup(c => c.Add(3, 3)).Returns(6).OccursOnce();
        _calculator.Setup(c => c.Add(6, 4)).Returns(10);//.OccursOnce();
        _calculator.Setup(c => c.Add(10, 5)).Returns(15).OccursOnce();

        var result = await _calculatorService.AddNumberSeriesAsync(1, 2, 3, 4, 5);

        result.ShouldBe(15, "My test message.");
    }
    
    [Test]
    public async Task TwoNumbers_SubtractNumbersAsync_ReturnsDifference()
    {
        _calculator.Setup(c => c.Subtract(20, 10)).Returns(10).OccursOnce();
        
        var result = await _calculatorService.SubtractNumbersAsync(20, 10);
        
        result.ShouldBe(10);
    }
}