using System.Linq.Expressions;
using RockHopper.Assertions;
using RockHopper.Mocking.Behaviors;
using RockHopper.Mocking.Setup;

// ReSharper disable UnusedParameter.Local
// ReSharper disable ClassNeverInstantiated.Local

namespace RockHopper.Test.Mocking.Behaviors;

public class VerifyCallTests 
{
    [Fact]
    public void ForExpressionNeverOccurring_NeverOccurs_AddsOccurenceToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new VerifyCall(setup);

        call.NeverOccurs();
        
        setup.Visits.Occurs.Count.ShouldBe(0);
    }
    
    [Fact]
    public void ForExpressionOccurringOnce_OccursOnce_AddsOccurenceToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new VerifyCall(setup);

        call.OccursOnce();
        
        setup.Visits.Occurs.Count.ShouldBe(1);
    }
    
    [Fact]
    public void ForExpressionOccurringMultipleTimes_OccursExactly_AddsOccurenceToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new VerifyCall(setup);

        call.OccursExactly(10);
        
        setup.Visits.Occurs.Count.ShouldBe(10);
    }
    
    [Fact]
    public void ForExpressionOccurringAtLeastOnce_OccursAtLeast_AddsOccurenceToSetup()
    {
        Expression<Action<Helper>> expression = h => h.Check(10, 20);
        var setup = new MethodSetupInfo(expression);
        var call = new VerifyCall(setup);

        call.OccursAtLeast(2);
        
        setup.Visits.Occurs.Count.ShouldBe(2);
    }
    
    private class Helper
    {
        public void Check(int x, int y)
        {
        }
    }
}