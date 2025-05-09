using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport;

namespace RockHopper.XUnit.Test;

public class PropertyTests
{
    private readonly CurrencyService _currencyService;
    private readonly Mock<Currency> _currency;

    public PropertyTests()
    {
        var testSubject = new TestSubject<CurrencyService>();
        _currencyService = testSubject;
        _currency = testSubject.GetMock<Currency>();
    }

    [Fact]
    public void ConvertValueToDollars_Convert_ReturnsValue()
    {
        _currency.GetProperty(c => c.Units).Returns("USD");

        var result = _currencyService.Convert(100);
        
        result.ShouldBe(110);
    }
    
    [Fact]
    public void ConvertValueToDollars_Convert_ReturnsValue2()
    {
        _currency.GetProperty(c => c.Units).Returns("USD");
        _currency.Setup(c => c.Units, "USD").OccursOnce();

        _currencyService.ChangeCurrency("USD");
        var result = _currencyService.Convert(100);
        
        result.ShouldBe(110);
    }
}