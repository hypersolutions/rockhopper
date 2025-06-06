﻿using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport.Conversion;

namespace RockHopper.XUnit.Test;

public class OutAndRefParameterTests
{
    private readonly ConverterService _converterService = TestSubject.Create<ConverterService>();
    private readonly Mock<IIntConverter> _intConverter;

    public OutAndRefParameterTests()
    {
        _intConverter = _converterService.GetMock<IIntConverter>();
    }
    
    [Fact]
    public void ValidIntAsString_GetValue_ReturnsIntResult()
    {
        var value = 123;
        _intConverter.Function(c => c.TryOutParse("123", out value)).Returns(true);

        var result = _converterService.GetValue("123");

        result.ShouldBe(123);
    }
    
    [Fact]
    public void ValidIntAsStringWithBaseValue_GetValue_ReturnsIntResult()
    {
        var value = 123;
        _intConverter.Function(c => c.TryRefParse("123", ref value)).Returns(true);

        var result = _converterService.GetValue("123", 100);

        result.ShouldBe(223);
    }
}