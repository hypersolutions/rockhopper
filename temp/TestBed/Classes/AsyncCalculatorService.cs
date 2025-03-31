namespace TestBed.Classes;

public sealed class AsyncCalculatorService
{
    private readonly ICalculator _calculator;

    public AsyncCalculatorService(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public Task<int> AddNumbersAsync(int x, int y) => Task.FromResult(_calculator.Add(x, y));

    public Task<int> AddNumberSeriesAsync(params int[] numbers)
    {
        var total = numbers[0];

        for (var i = 1; i < numbers.Length; i++)
        {
            total = _calculator.Add(total, numbers[i]);
        }

        return Task.FromResult(total);
    }
    
    public Task<int> SubtractNumbersAsync(int x, int y) => Task.FromResult(_calculator.Subtract(x, y));
}