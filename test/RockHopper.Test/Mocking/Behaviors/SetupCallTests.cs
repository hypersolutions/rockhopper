using System.Linq.Expressions;
using RockHopper.Assertions;
using RockHopper.Mocking.Behaviors;
using RockHopper.Mocking.Setup;
// ReSharper disable UnusedMethodReturnValue.Local - Part of test pattern

namespace RockHopper.Test.Mocking.Behaviors;

public class SetupCallTests
{
    [Fact]
    public void ForExpressionNeverOccurring_NeverOccurs_AddsOccurenceToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<NoReturn>(setup);

        call.NeverOccurs();
        
        setup.Visits.Occurs.Count.ShouldBe(0);
    }
    
    [Fact]
    public void ForExpressionOccurringOnce_OccursOnce_AddsOccurenceToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<NoReturn>(setup);

        call.OccursOnce();
        
        setup.Visits.Occurs.Count.ShouldBe(1);
    }
    
    [Fact]
    public void ForExpressionOccurringMultipleTimes_OccursExactly_AddsOccurenceToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<NoReturn>(setup);

        call.OccursExactly(10);
        
        setup.Visits.Occurs.Count.ShouldBe(10);
    }
    
    [Fact]
    public void ForExpressionOccurringAtLeastOnce_OccursAtLeast_AddsOccurenceToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<NoReturn>(setup);

        call.OccursAtLeast(2);
        
        setup.Visits.Occurs.Count.ShouldBe(2);
    }
    
    [Fact]
    public void ForExpressionThrowingException_Throws_AddsExceptionToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<NoReturn>(setup);

        call.Throws<Exception>();

        setup.Exceptions.GetNext().ShouldNotBeNull();
    }
    
    [Fact]
    public void ForExpressionThrowingExceptionInstance_Throws_AddsExceptionToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<NoReturn>(setup);

        call.Throws(new Exception());

        setup.Exceptions.GetNext().ShouldNotBeNull();
    }
    
    [Fact]
    public void SingleReturnValue_Returns_AddsReturnValueToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Add(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<int>(setup);

        call.Returns(30);

        var result = (int)setup.ReturnValues.GetNext()!;
        result.ShouldBe(30);
    }
    
    [Fact]
    public void MultipleReturnValues_Returns_AddsReturnValuesToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Add(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<int>(setup);
        call.Returns(30);
        
        call.Returns(50);

        var result = (int)setup.ReturnValues.GetNext()!;
        result.ShouldBe(30);
        result = (int)setup.ReturnValues.GetNext()!;
        result.ShouldBe(50);
    }
    
    [Fact]
    public void SingleReturnFuncValue_Returns_AddsReturnFuncValueToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Add(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<int>(setup);

        call.Returns(() => 30);

        var result = (int)setup.ReturnValues.GetNext()!;
        result.ShouldBe(30);
    }
    
    [Fact]
    public void MultipleReturnFuncValue_Returns_AddsReturnFuncValuesToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Add(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<int>(setup);

        call.Returns(() => 30, () => 50);

        var result = (int)setup.ReturnValues.GetNext()!;
        result.ShouldBe(30);
        result = (int)setup.ReturnValues.GetNext()!;
        result.ShouldBe(50);
    }
    
    [Fact]
    public async Task SingleAsyncReturnValue_ReturnsAsync_AddsAsyncReturnValueToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Add(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<int>(setup);

        call.ReturnsAsync(30);

        var result = await (Task<int>)setup.ReturnValues.GetNext()!;
        result.ShouldBe(30);
    }
    
    [Fact]
    public async Task MultipleAsyncReturnValue_ReturnsAsync_AddsAsyncReturnValuesToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Add(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new SetupCall<int>(setup);

        call.ReturnsAsync(30, 50);

        var result = await (Task<int>)setup.ReturnValues.GetNext()!;
        result.ShouldBe(30);
        result = await (Task<int>)setup.ReturnValues.GetNext()!;
        result.ShouldBe(50);
    }
    
    private class Helper
    {
        public void Check(int x, int y)
        {
            Console.WriteLine($"{x} and {y}");
        }
        
        public int Add(int x, int y) => x + y;
    }
}