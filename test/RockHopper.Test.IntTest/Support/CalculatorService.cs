namespace RockHopper.Test.IntTest.Support;

public sealed class CalculatorService
{
    private readonly Calculator _calculator;

    public CalculatorService(Calculator calculator)
    {
        _calculator = calculator;
    }

    public int AddNumbers(int x, int y)
    {
        return AddNumberSeries(x, y);
    }

    public int AddNumberSeries(params int[] numbers)
    {
        var total = numbers[0];

        for (var i = 1; i < numbers.Length; i++)
        {
            total = _calculator.Add(total, numbers[i]);
        }

        return total;
    }

    public int SubtractNumbers(int x, int y)
    {
        return _calculator.Subtract(x, y);
    }
}