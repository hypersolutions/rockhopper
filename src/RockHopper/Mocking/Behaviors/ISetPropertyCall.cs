namespace RockHopper.Mocking.Behaviors;

public interface ISetPropertyCall : IMethodCall
{
    IVerifyCall WithValue<TValue>(TValue value);
    IVerifyCall WithValue<TValue>(Func<TValue?> valueFunc);
}