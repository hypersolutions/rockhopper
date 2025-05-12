using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport;

namespace RockHopper.XUnit.Test;

public class PropertyTests
{
    private readonly TestSubject<CurrencyService> _testSubject;
    private readonly CurrencyService _currencyService;
    private readonly Mock<Currency> _currency;

    public PropertyTests()
    {
        _testSubject = new TestSubject<CurrencyService>();
        _currencyService = _testSubject;
        _currency = _testSubject.GetMock<Currency>();
    }

    [Fact]
    public void ConvertValueToDollars_Convert_ReturnsValue()
    {
        _currency.GetProperty(c => c.Units).Returns("USD");

        var result = _currencyService.Convert(100);
        
        result.ShouldBe(110);
    }
    
    [Fact]
    public void ConvertValueToDollars_ChangeCurrency_ReturnsConvertedValue()
    {
        _currency.GetProperty(c => c.Units).Returns("USD");
        _currency.SetProperty(c => c.Units).WithValue("USD");

        _currencyService.ChangeCurrency("USD");
        var result = _currencyService.Convert(100);
        
        result.ShouldBe(110);
    }
    
    [Fact]
    public void ConvertValueToDollars_ChangeCurrency_VerifyAllCalls()
    {
        _currency.GetProperty(c => c.Units).Returns("USD").OccursOnce();
        _currency.SetProperty(c => c.Units).WithValue(() => "USD").OccursOnce();

        _currencyService.ChangeCurrency("USD");
        _ = _currencyService.Convert(100);
        
        _testSubject.VerifyAll();
    }
}