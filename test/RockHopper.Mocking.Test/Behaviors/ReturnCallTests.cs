using System.Linq.Expressions;
using RockHopper.Assertions;
using RockHopper.Mocking.Behaviors;
using RockHopper.Mocking.Setup;

// ReSharper disable UnusedMethodReturnValue.Local
// ReSharper disable ClassNeverInstantiated.Local

namespace RockHopper.Mocking.Test.Behaviors;

public class ReturnCallTests 
{
    [Fact]
    public void ForExpressionThrowingException_Throws_AddsExceptionToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Add(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new ReturnCall<int>(setup);

        call.Throws<Exception>();

        setup.Exceptions.GetNext().ShouldNotBeNull();
    }
    
    [Fact]
    public void ForExpressionThrowingExceptionInstance_Throws_AddsExceptionToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Add(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new ReturnCall<int>(setup);

        call.Throws(new Exception());

        setup.Exceptions.GetNext().ShouldNotBeNull();
    }
    
    private class Helper
    {
        public int Add(int x, int y) => x + y;
    }
}