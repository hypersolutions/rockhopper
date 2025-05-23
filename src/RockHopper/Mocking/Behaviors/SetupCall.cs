using RockHopper.Mocking.Parameters;
using RockHopper.Mocking.Setup;
using RockHopper.Mocking.Verifies;

namespace RockHopper.Mocking.Behaviors;

internal sealed class SetupCall : IReturnCall, ISetPropertyCall
{
    private readonly SetupInfo _setupInfo;

    internal SetupCall(SetupInfo setupInfo)
    {
        _setupInfo = setupInfo;
    }
    
    public IVerifyCall Throws<TException>() where TException : Exception, new()
    {
        return Throws(new TException());
    }

    public IVerifyCall Throws(Exception exception)
    {
        ArgumentNullException.ThrowIfNull(exception);

        _setupInfo.Exceptions.Add(exception);

        return this;
    }
    
    public IVerifyCall Returns<TReturn>(params TReturn[] returnValues)
    {
        var isTaskReturn = _setupInfo is MethodSetupInfo { ReturnTypeIsTask: true };
        var isValueTaskReturn = _setupInfo is MethodSetupInfo { ReturnTypeIsValueTask: true };
        
        foreach (var returnValue in returnValues)
        {
            if (isTaskReturn)
            {
                _setupInfo.ReturnValues.Add(Task.FromResult(returnValue));
            }
            else if (isValueTaskReturn)
            {
                _setupInfo.ReturnValues.Add(ValueTask.FromResult(returnValue));
            }
            else
            {
                _setupInfo.ReturnValues.Add(returnValue);
            }
        }

        _setupInfo.Visits.AddOccurs(_setupInfo.FullName, Occurs.Exactly(_setupInfo.ReturnValues.Count));
        
        return this;
    }
    
    public IVerifyCall Returns<TReturn>(params Func<TReturn?>[] functions)
    {
        foreach (var function in functions)
        {
            _setupInfo.ReturnValues.Add(function, true);
        }
        
        _setupInfo.Visits.AddOccurs(_setupInfo.FullName, Occurs.Exactly(_setupInfo.ReturnValues.Count));
        
        return this;
    }
    
    public void NeverOccurs()
    {
        _setupInfo.Visits.AddOccurs(_setupInfo.FullName, Occurs.Never());
    }

    public void OccursOnce()
    {
        _setupInfo.Visits.AddOccurs(_setupInfo.FullName, Occurs.Once());
    }

    public void OccursExactly(int count)
    {
        _setupInfo.Visits.AddOccurs(_setupInfo.FullName, Occurs.Exactly(count));
    }

    public void OccursAtLeast(int count)
    {
        _setupInfo.Visits.AddOccurs(_setupInfo.FullName, Occurs.AtLeast(count));
    }

    public IVerifyCall WithValue<TValue>(TValue? value)
    {
        WithValue(() => value);
        return this;
    }
    
    public IVerifyCall WithValue<TValue>(Func<TValue?> valueFunc)
    {
        var parameter = new Parameter { Matcher = ParameterMatcherFactory.Create(valueFunc), Type = ParameterType.In };
        _setupInfo.AddParameter(parameter);
        _setupInfo.Visits.AddOccurs(_setupInfo.FullName, Occurs.Once());
        return this;
    }
}