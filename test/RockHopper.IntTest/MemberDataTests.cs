using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;

namespace RockHopper.IntTest;

public class MemberDataTests
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<Calculator> _calculator = TestContext.Mock<Calculator>();

    [Test(MemberArgs = nameof(Data))]
    public void TwoNumbers_AddNumbers_ReturnsSum(int first, int second, int expectedResult)
    {
        _calculator.Setup(c => c.Add(first, second)).Returns(expectedResult);

        var result = _calculatorService.AddNumbers(first, second);
        
        result.ShouldBe(expectedResult);
    }
    
    public static IEnumerable<(int First, int Second, int ExpectedResult)> Data =>
        new List<(int First, int Second, int ExpectedResult)>
        {
            new ( 1, 2, 3 ),
            new ( -1, -2, -3 ),
            new ( -1, 2, 1 ),
            new ( -1, 1, 0 )
        };
}