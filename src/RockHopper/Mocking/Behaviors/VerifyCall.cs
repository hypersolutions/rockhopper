using RockHopper.Mocking.Setup;
using RockHopper.Mocking.Verifies;

namespace RockHopper.Mocking.Behaviors;

/// <summary>
/// Defines the setup verify call of a method, function, property etc.
/// </summary>
public class VerifyCall
{
    private readonly SetupInfo _setupInfo;
    
    internal VerifyCall(SetupInfo setupInfo) 
    {
        _setupInfo = setupInfo;
        _setupInfo.Visits.AddOccurs(Occurs.Exactly(_setupInfo.ReturnValues.Count));
    }

    /// <summary>
    /// Expecting no call to be made.
    /// </summary>
    public void NeverOccurs()
    {
        _setupInfo.Visits.AddOccurs(Occurs.Never());
    }

    /// <summary>
    /// Expecting a single call to be made.
    /// </summary>
    public void OccursOnce()
    {
        _setupInfo.Visits.AddOccurs(Occurs.Once());
    }

    /// <summary>
    /// Expecting a single call to be made.
    /// </summary>
    /// <param name="count">Number of times to check the call was made</param>
    public void OccursExactly(int count)
    {
        _setupInfo.Visits.AddOccurs(Occurs.Exactly(count));
    }

    /// <summary>
    /// Expecting a single call to be made.
    /// </summary>
    /// <param name="count">Number of times to check the call was made at least</param>
    public void OccursAtLeast(int count)
    {
        _setupInfo.Visits.AddOccurs(Occurs.AtLeast(count));
    }
}