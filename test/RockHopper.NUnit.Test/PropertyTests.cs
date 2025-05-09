using NUnit.Framework;
using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport;

namespace RockHopper.NUnit.Test;

public class PropertyTests
{
    private CurrencyService _currencyService;
    private Mock<Currency> _currency;

    [SetUp]
    public void BeforeEachTest()
    {
        var testSubject = new TestSubject<CurrencyService>();
        _currencyService = testSubject;
        _currency = testSubject.GetMock<Currency>();
    }

    [Test]
    public void ConvertValueToDollars_Convert_ReturnsValue()
    {
        _currency.Setup(c => c.Units).Returns("USD");

        var result = _currencyService.Convert(100);
        
        result.ShouldBe(110);
    }
    
    [Test]
    public void ConvertValueToDollars_Convert_ReturnsValue2()
    {
        _currency.Setup(c => c.Units).Returns("USD");
        _currency.Setup(c => c.Units, "USD").OccursOnce();

        _currencyService.ChangeCurrency("USD");
        var result = _currencyService.Convert(100);
        
        result.ShouldBe(110);
    }
}