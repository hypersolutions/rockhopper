using System.Linq.Expressions;
using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;
using RockHopper.Mocking.Parameters;
using RockHopper.Mocking.Setup;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable ClassNeverInstantiated.Local

namespace RockHopper.Test.Mocking.Setup;

public class SetPropertySetupInfoTests 
{
    [Fact]
    public void NonOverridableProperty_Ctor_ThrowsException()
    {
        Expression<Func<Helper, bool>> expression = h => h.CountGreaterThanZero;
    
        var exception = Should.Throw<MockException>(() => _ = new SetPropertySetupInfo(expression));
        
        exception.Message.ShouldBe("Provided method or property CountGreaterThanZero is not virtual or abstract.");
    }
    
    [Fact]
    public void FromProperty_Ctor_SetsName()
    {
        Expression<Func<Helper, int>> expression = h => h.Count;

        var setup = new SetPropertySetupInfo(expression);
        
        setup.Name.ShouldBe("set_Count");
    }
    
    [Fact]
    public void FromPropertyIndexer_Ctor_SetsName()
    {
        Expression<Func<Helper, int>> expression = h => h[0];
        
        var setup = new SetPropertySetupInfo(expression);
        
        setup.Name.ShouldBe("set_Item");
    }
    
    [Fact]
    public void FromPropertyIndexer_Ctor_SetsParameter()
    {
        Expression<Func<Helper, int>> expression = h => h[2];
        
        var setup = new SetPropertySetupInfo(expression);
        
        var parameters = setup.Parameters.ToArray();
        parameters.Length.ShouldBe(1);
        AssertParameter<ExactParameterMatcher>(parameters[0], 2, ParameterType.In);
    }
    
    private static void AssertParameter<TMatcher>(Parameter parameter, object? value, ParameterType parameterType)
        where TMatcher : ParameterMatcher
    {
        parameter.Matcher.IsMatch(value).ShouldBeTrue();
        parameter.Type.ShouldBe(parameterType);
        parameter.Matcher.ShouldBeOfType<TMatcher>();
    }
    
    private abstract class Helper
    {
        public abstract int Count { get; set; }
        
        public bool CountGreaterThanZero { get; set; }

        public virtual int this[int index]
        {
            get => index;
            set => _ = value;
        }
    }
}