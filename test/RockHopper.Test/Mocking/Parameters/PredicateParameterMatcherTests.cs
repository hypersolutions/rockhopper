﻿using RockHopper.Assertions;
using RockHopper.Mocking.Parameters;

namespace RockHopper.Test.Mocking.Parameters;

public class PredicateParameterMatcherTests 
{
    [Fact]
    public void ValidCondition_IsMatch_ReturnsTrue()
    {
        var matcher = new PredicateParameterMatcher();
        matcher.SetValue(() => new Func<int, bool>(p => p < 10));
        
        var matches = matcher.IsMatch(9);
        
        matches.ShouldBeTrue();
    }
    
    [Fact]
    public void InvalidCondition_IsMatch_ReturnsFalse()
    {
        var matcher = new PredicateParameterMatcher();
        matcher.SetValue(() => new Func<int, bool>(p => p < 10));
        
        var matches = matcher.IsMatch(11);
        
        matches.ShouldBeFalse();
    }
}