using System.Linq.Expressions;
using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;
using RockHopper.Mocking.Parameters;
using RockHopper.Mocking.Setup;

// ReSharper disable UnusedParameter.Global
// ReSharper disable ReplaceAutoPropertyWithComputedProperty
// ReSharper disable UnusedParameter.Local
// ReSharper disable ClassNeverInstantiated.Local

namespace RockHopper.Test.Mocking.Setup;

public class GetPropertySetupInfoTests 
{
    [Fact]
    public void NonOverridableProperty_Ctor_ThrowsException()
    {
        Expression<Func<Helper, bool>> expression = h => h.CountGreaterThanZero;
    
        var exception = Should.Throw<MockException>(() => _ = new GetPropertySetupInfo(expression));
        
        exception.Message.ShouldBe("Provided method or property CountGreaterThanZero is not virtual or abstract.");
    }
    
    [Fact]
    public void FromProperty_Ctor_SetsName()
    {
        Expression<Func<Helper, int>> expression = h => h.Count;
        
        var setup = new GetPropertySetupInfo(expression);
        
        setup.Name.ShouldBe("get_Count");
    }
    
    [Fact]
    public void FromPropertyIndexer_Ctor_SetsName()
    {
        Expression<Func<Helper, int>> expression = h => h[0];
        
        var setup = new GetPropertySetupInfo(expression);
        
        setup.Name.ShouldBe("get_Item");
    }
    
    [Fact]
    public void FromPropertyIndexer_Ctor_SetsParameter()
    {
        Expression<Func<Helper, int>> expression = h => h[2];
        
        var setup = new GetPropertySetupInfo(expression);
        
        var parameters = setup.Parameters.ToArray();
        parameters.ShouldBeSingle();
        AssertParameter<ExactParameterMatcher>(parameters[0], 2, ParameterType.In);
    }
    
    private static void AssertParameter<TMatcher>(Parameter parameter, object? value, ParameterType parameterType)
        where TMatcher : ParameterMatcher
    {
        parameter.Matcher.IsMatch(value).ShouldBeTrue();
        parameter.Type.ShouldBe(parameterType);
        parameter.Matcher.ShouldBeOfType<TMatcher>();
    }
    
    private class Helper
    {
        public virtual int Count { get; } = 0;

        public virtual int this[int index] => 0;
        
        public bool CountGreaterThanZero => Count > 0;
    }
}