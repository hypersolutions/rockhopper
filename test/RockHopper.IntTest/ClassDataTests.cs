using System.Collections;
using RockHopper.Assertions;
using RockHopper.IntTest.Support;
using RockHopper.Mocking;

namespace RockHopper.IntTest;

public class ClassDataTests
{
    private readonly CalculatorService _calculatorService = TestContext.Subject<CalculatorService>();
    private readonly Mock<Calculator> _calculator = TestContext.Mock<Calculator>();

    [Test(ClassArgs = typeof(Data))]
    public void TwoNumbers_AddNumbers_ReturnsSum(int first, int second, int expectedResult)
    {
        _calculator.Setup(c => c.Add(first, second)).Returns(expectedResult);

        var result = _calculatorService.AddNumbers(first, second);
        
        result.ShouldBe(expectedResult);
    }
    
    private sealed class Data : IEnumerable<(int, int, int)>
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
}