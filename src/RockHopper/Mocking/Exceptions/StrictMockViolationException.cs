using System.Reflection;

namespace RockHopper.Mocking.Exceptions;

/// <summary>
/// Defines an exception for violations of the strict mock setup.
/// </summary>
public sealed class StrictMockViolationException : Exception
{
    private const string MessageTemplate = 
        "There is no setup for the call '{0}'. All calls using a strict mock must be defined.";

    private const string GetPrefix = "get_";
    private const string SetPrefix = "set_";

    internal StrictMockViolationException(MethodBase method) : base(GetFormattedMessage(method))
    {
    }

    private static string GetFormattedMessage(MethodBase method)
    {
        var name = method.Name;
        
        if (method.IsSpecialName)
        {
            if (name.StartsWith(GetPrefix))
                name = name.Replace(GetPrefix, string.Empty);
            else if (name.StartsWith(SetPrefix))
                name = name.Replace(SetPrefix, string.Empty);
        }

        return string.Format(MessageTemplate, name);
    }
}