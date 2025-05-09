namespace RockHopper.TestSupport;

public abstract class Currency
{
    public abstract string Units { get; set; }
}

public sealed class CurrencyService
{
    private readonly Currency _currency;

    public CurrencyService(Currency currency)
    {
        _currency = currency;
    }

    public decimal Convert(decimal value)
    {
        return _currency.Units == "USD" ? 1.1M * value : value;
    }

    public void ChangeCurrency(string units)
    {
        _currency.Units = units;
    }
}