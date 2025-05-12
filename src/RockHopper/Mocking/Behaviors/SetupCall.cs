using RockHopper.Mocking.Parameters;
using RockHopper.Mocking.Setup;
using RockHopper.Mocking.Verifies;

namespace RockHopper.Mocking.Behaviors;

internal sealed class SetupCall<TReturn> : IReturnCall<TReturn>, ISetPropertyCall
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
    
    public IVerifyCall Returns(params TReturn[] returnValues)
    {
        foreach (var returnValue in returnValues)
        {
            _setupInfo.ReturnValues.Add(returnValue);
        }

        _setupInfo.Visits.AddOccurs(Occurs.Exactly(_setupInfo.ReturnValues.Count));
        
        return this;
    }
    
    public IVerifyCall Returns(params Func<TReturn?>[] functions)
    {
        foreach (var function in functions)
        {
            _setupInfo.ReturnValues.Add(function, true);
        }
        
        _setupInfo.Visits.AddOccurs(Occurs.Exactly(_setupInfo.ReturnValues.Count));
        
        return this;
    }
    
    public IVerifyCall ReturnsAsync(params TReturn?[] returnValues)
    {
        foreach (var returnValue in returnValues)
        {
            _setupInfo.ReturnValues.Add(Task.FromResult(returnValue));
        }
        
        return this;
    }
    
    public void NeverOccurs()
    {
        _setupInfo.Visits.AddOccurs(Occurs.Never());
    }

    public void OccursOnce()
    {
        _setupInfo.Visits.AddOccurs(Occurs.Once());
    }

    public void OccursExactly(int count)
    {
        _setupInfo.Visits.AddOccurs(Occurs.Exactly(count));
    }

    public void OccursAtLeast(int count)
    {
        _setupInfo.Visits.AddOccurs(Occurs.AtLeast(count));
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
        _setupInfo.Visits.AddOccurs(Occurs.Once());
        return this;
    }
}