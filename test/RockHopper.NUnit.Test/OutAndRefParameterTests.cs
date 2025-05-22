using NUnit.Framework;
using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport.Conversion;

namespace RockHopper.NUnit.Test;

public class OutAndRefParameterTests
{
    private readonly ConverterService _converterService;
    private readonly Mock<IIntConverter> _intConverter;

    public OutAndRefParameterTests()
    {
        _converterService = TestSubject.Create<ConverterService>();
        _intConverter = _converterService.GetMock<IIntConverter>();
    }
    
    [Test]
    public void ValidIntAsString_GetValue_ReturnsIntResult()
    {
        var value = 123;
        _intConverter.Function(c => c.TryOutParse("123", out value)).Returns(true);

        var result = _converterService.GetValue("123");

        result.ShouldBe(123);
    }
    
    [Test]
    public void ValidIntAsStringWithBaseValue_GetValue_ReturnsIntResult()
    {
        var value = 123;
        _intConverter.Function(c => c.TryRefParse("123", ref value)).Returns(true);

        var result = _converterService.GetValue("123", 100);

        result.ShouldBe(223);
    }
}