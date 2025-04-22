using System.Linq.Expressions;
using RockHopper.Assertions;
using RockHopper.Mocking.Behaviors;
using RockHopper.Mocking.Setup;

// ReSharper disable ClassNeverInstantiated.Local

namespace RockHopper.Test.Mocking.Behaviors;

public class MethodCallTests 
{
    [Fact]
    public void ForExpressionThrowingException_Throws_AddsExceptionToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new MethodCall(setup);

        call.Throws<Exception>();

        setup.Exceptions.GetNext().ShouldNotBeNull();
    }
    
    [Fact]
    public void ForExpressionThrowingExceptionInstance_Throws_AddsExceptionToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new MethodCall(setup);

        call.Throws(new Exception());

        setup.Exceptions.GetNext().ShouldNotBeNull();
    }
    
    private class Helper
    {
        public void Check(int x, int y)
        {
            Console.WriteLine($"{x} and {y}");
        }
    }
}