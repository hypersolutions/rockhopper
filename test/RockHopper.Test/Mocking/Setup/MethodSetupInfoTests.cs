using System.Linq.Expressions;
using RockHopper.Assertions;
using RockHopper.Mocking.Exceptions;
using RockHopper.Mocking.Parameters;
using RockHopper.Mocking.Setup;

// ReSharper disable UnusedMethodReturnValue.Local

namespace RockHopper.Test.Mocking.Setup;

public class MethodSetupInfoTests 
{
    [Fact]
    public void NonOverridableMethod_Ctor_ThrowsException()
    {
        Expression<Action<Helper>> expression = h => h.IsPositive(10);

        var exception = Should.Throw<MockException>(() => _ = new MethodSetupInfo(expression));
        
        exception.Message.ShouldBe("Provided method or property IsPositive is not virtual or abstract.");
    }
    
    [Fact]
    public void FromMethod_Ctor_SetsName()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        
        var setup = new MethodSetupInfo(expression);
        
        setup.Name.ShouldBe("Check");
    }
    
    [Fact]
    public void FromMethod_Ctor_SetsParameters()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        
        var setup = new MethodSetupInfo(expression);

        var parameters = setup.Parameters.ToArray();
        parameters.Length.ShouldBe(2);
        AssertParameter<ExactParameterMatcher>(parameters[0], 10, ParameterType.In);
        AssertParameter<ExactParameterMatcher>(parameters[1], 20, ParameterType.In);
    }

    [Fact]
    public void FromFunction_Ctor_SetsName()
    {
        Expression<Func<Helper, int>> expression = h => h.Add(10, 20);
        
        var setup = new MethodSetupInfo(expression);
        
        setup.Name.ShouldBe("Add");
    }
    
    [Fact]
    public void FromFunction_Ctor_SetsParameters()
    {
        Expression<Func<Helper, int>> expression = h => h.Add(10, 20);
        
        var setup = new MethodSetupInfo(expression);

        var parameters = setup.Parameters.ToArray();
        parameters.Length.ShouldBe(2);
        AssertParameter<ExactParameterMatcher>(parameters[0], 10, ParameterType.In);
        AssertParameter<ExactParameterMatcher>(parameters[1], 20, ParameterType.In);
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
        public virtual void Check(int x, int y)
        {
            Console.WriteLine($"{x} and {y}");
        }
        
        public virtual int Add(int x, int y)
        {
            return x + y;
        }

        public bool IsPositive(int x)
        {
            return x >= 0;
        }
    }
}