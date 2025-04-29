using System.Linq.Expressions;
using Castle.DynamicProxy;
using RockHopper.Mocking.Behaviors;
using RockHopper.Mocking.Extensions;
using RockHopper.Mocking.Setup;

namespace RockHopper.Mocking;

/// <summary>
/// Base class for mocks with factory methods.
/// </summary>
public abstract class Mock
{
    internal abstract object GetInstance();
    
    internal abstract void VerifyAll();
}

/// <summary>
/// Defines a generic mock of a type.
/// </summary>
/// <typeparam name="T">Mock type</typeparam>
public sealed class Mock<T> : Mock where T : class
{
    private readonly List<SetupInfo> _setupInfoList = [];
    
    public Mock()
    {
        var mockType = typeof(T);
        var interceptor = new MockInterceptor(_setupInfoList);
        var proxyGenerator = new ProxyGenerator();
        Object = mockType.IsInterface
            ? proxyGenerator.CreateInterfaceProxyWithoutTarget<T>(interceptor)
            : proxyGenerator.CreateClassProxy<T>(interceptor);
    }

    /// <summary>
    /// Gets the mock type instance.
    /// </summary>
    public T Object { get; }
    
    /// <summary>
    /// Sets up the behaviour on a method.
    /// </summary>
    /// <param name="expression">Method expression</param>
    /// <returns>Method call behaviours</returns>
    public MethodCall Setup(Expression<Action<T>> expression)
    {
        var setupInfo = new MethodSetupInfo(expression);
        _setupInfoList.Add(setupInfo);
        return new MethodCall(setupInfo);
    }

    /// <summary>
    /// Sets up the behaviour on a function.
    /// </summary>
    /// <typeparam name="TReturn">Return type</typeparam>
    /// <param name="expression">Function expression</param>
    /// <returns>Function call behaviours</returns>
    public ReturnCall<TReturn> Setup<TReturn>(Expression<Func<T, TReturn?>> expression)
    {
        SetupInfo setupInfo = expression.IsGetPropertyExpression() 
            ? new GetPropertySetupInfo(expression)
            :  new MethodSetupInfo(expression);
        _setupInfoList.Add(setupInfo);
        return new ReturnCall<TReturn>(setupInfo);
    }

    /// <summary>
    /// Sets up the behaviour on a function that returns a Task.
    /// </summary>
    /// <typeparam name="TReturn">Return type</typeparam>
    /// <param name="expression">Function expression</param>
    /// <returns>Function call behaviours</returns>
    public ReturnCall<TReturn> Setup<TReturn>(Expression<Func<T, Task<TReturn?>>> expression)
    {
        SetupInfo setupInfo = expression.IsGetPropertyExpression() 
            ? new GetPropertySetupInfo(expression)
            :  new MethodSetupInfo(expression);
        _setupInfoList.Add(setupInfo);
        return new ReturnCall<TReturn>(setupInfo);
    }

    /// <summary>
    /// Sets up the behaviour on a set property.
    /// </summary>
    /// <param name="expression">Set property expression</param>
    /// <param name="value">Value to set</param>
    /// <returns>Method call behaviours</returns>
    public MethodCall Setup<TValue>(Expression<Func<T, TValue?>> expression, TValue? value)
    {
        return Setup(expression, () => value);
    }
    
    /// <summary>
    /// Sets up the behaviour on a set property.
    /// </summary>
    /// <param name="expression">Set property expression</param>
    /// <param name="valueFunc">Value to set</param>
    /// <returns>Method call behaviours</returns>
    public MethodCall Setup<TValue>(Expression<Func<T, TValue?>> expression, Func<TValue?> valueFunc)
    {
        var setupInfo = new SetPropertySetupInfo<TValue>(expression, valueFunc);
        _setupInfoList.Add(setupInfo);
        return new MethodCall(setupInfo);
    }
    
    internal override object GetInstance() => Object;
    
    internal override void VerifyAll()
    {
        foreach (var setup in _setupInfoList)
        {
            setup.Visits.VerifyOccurs();
            setup.ReturnValues.Reset();
        }
    }
    
    private sealed class MockInterceptor : IInterceptor
    {
        private readonly List<SetupInfo> _setupInfoList;

        public MockInterceptor(List<SetupInfo> setupInfoList)
        {
            _setupInfoList = setupInfoList;
        }
    
        public void Intercept(IInvocation invocation)
        {
            var setupInfo = _setupInfoList.FindBy(invocation.Method, invocation.Arguments);
            invocation.ReturnValue = setupInfo.HandleResponse<object?>(invocation.Arguments);
        }
    }
}