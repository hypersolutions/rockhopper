using System.Linq.Expressions;
using RockHopper.Assertions;
using RockHopper.Mocking.Parameters;
using RockHopper.Mocking.Setup;

namespace RockHopper.Test.Mocking.Setup;

public class MethodSetupInfoTests 
{
    [Test]
    public void FromMethod_Ctor_SetsName()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        
        var setup = new MethodSetupInfo(expression);
        
        setup.Name.ShouldBe("Check");
    }
    
    [Test]
    public void FromMethod_Ctor_SetsParameters()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        
        var setup = new MethodSetupInfo(expression);

        var parameters = setup.Parameters.ToArray();
        parameters.Length.ShouldBe(2);
        AssertParameter<ExactParameterMatcher>(parameters[0], 10, ParameterType.In);
        AssertParameter<ExactParameterMatcher>(parameters[1], 20, ParameterType.In);
    }

    [Test]
    public void FromFunction_Ctor_SetsName()
    {
        Expression<Func<Helper, int>> expression = h => h.Add(10, 20);
        
        var setup = new MethodSetupInfo(expression);
        
        setup.Name.ShouldBe("Add");
    }
    
    [Test]
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
        public void Check(int x, int y)
        {
            Console.WriteLine($"{x} and {y}");
        }
        
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}