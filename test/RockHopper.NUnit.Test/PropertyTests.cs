using NUnit.Framework;
using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport;

namespace RockHopper.NUnit.Test;

public class PropertyTests
{
    private TestSubject<CurrencyService> _testSubject;
    private CurrencyService _currencyService;
    private Mock<Currency> _currency;

    [SetUp]
    public void BeforeEachTest()
    {
        _testSubject = new TestSubject<CurrencyService>();
        _currencyService = _testSubject;
        _currency = _testSubject.GetMock<Currency>();
    }

    [Test]
    public void ConvertValueToDollars_Convert_ReturnsValue()
    {
        _currency.GetProperty(c => c.Units).Returns("USD");

        var result = _currencyService.Convert(100);
        
        result.ShouldBe(110);
    }
    
    [Test]
    public void ConvertValueToDollars_ChangeCurrency_ReturnsConvertedValue()
    {
        _currency.GetProperty(c => c.Units).Returns("USD");
        _currency.SetProperty(c => c.Units).WithValue("USD");

        _currencyService.ChangeCurrency("USD");
        var result = _currencyService.Convert(100);
        
        result.ShouldBe(110);
    }
    
    [Test]
    public void ConvertValueToDollars_ChangeCurrency_VerifyAllCalls()
    {
        _currency.GetProperty(c => c.Units).Returns("USD").OccursOnce();
        _currency.SetProperty(c => c.Units).WithValue(() => "USD").OccursOnce();

        _currencyService.ChangeCurrency("USD");
        _ = _currencyService.Convert(100);
        
        _testSubject.VerifyAll();
    }
}