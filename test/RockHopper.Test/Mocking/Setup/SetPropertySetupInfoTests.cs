using System.Linq.Expressions;
using RockHopper.Assertions;
using RockHopper.Mocking.Parameters;
using RockHopper.Mocking.Setup;

// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable ClassNeverInstantiated.Local

namespace RockHopper.Test.Mocking.Setup;

public class SetPropertySetupInfoTests 
{
    [Fact]
    public void FromProperty_Ctor_SetsName()
    {
        Expression<Func<Helper, int>> expression = h => h.Count;

        var setup = new SetPropertySetupInfo<int>(expression, ValueFunc);
        
        setup.Name.ShouldBe("set_Count");
        return;

        int ValueFunc() => 10;
    }
    
    [Fact]
    public void FromPropertyIndexer_Ctor_SetsName()
    {
        Expression<Func<Helper, int>> expression = h => h[0];
        
        var setup = new SetPropertySetupInfo<int>(expression, ValueFunc);
        
        setup.Name.ShouldBe("set_Item");
        
        return;

        int ValueFunc() => 10;
    }
    
    [Fact]
    public void FromPropertyIndexer_Ctor_SetsParameter()
    {
        Expression<Func<Helper, int>> expression = h => h[2];
        
        var setup = new SetPropertySetupInfo<int>(expression, ValueFunc);
        
        var parameters = setup.Parameters.ToArray();
        parameters.Length.ShouldBe(2);
        AssertParameter<ExactParameterMatcher>(parameters[0], 2, ParameterType.In);
        AssertParameter<ExactParameterMatcher>(parameters[1], 10, ParameterType.In);
        
        return;

        int ValueFunc() => 10;
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
        public int Count { get; set; }

        public int this[int index]
        {
            get => index;
            set => _ = value;
        }
    }
}