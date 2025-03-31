namespace TestBed.Classes;

public sealed class CalculatorService2
{
    private readonly ICalculator _calculator;

    public CalculatorService2(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public int AddNumbers(int x, int y) => _calculator.Add(x, y);

    public int AddNumberSeries(params int[] numbers)
    {
        var total = numbers[0];

        for (var i = 1; i < numbers.Length; i++)
        {
            total = _calculator.Add(total, numbers[i]);
        }

        return total;
    }
    
    public int SubtractNumbers(int x, int y) => _calculator.Subtract(x, y);
}