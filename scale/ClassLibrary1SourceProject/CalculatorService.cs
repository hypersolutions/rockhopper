namespace ClassLibrary1SourceProject;

public sealed class CalculatorService
{
    private readonly ICalculator _calculator;

    public CalculatorService(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public int AddNumbers(int x, int y) => _calculator.Add(x, y);
    
    public int SubtractNumbers(int x, int y) => _calculator.Subtract(x, y);
}