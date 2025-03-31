using System.Reflection;
using RockHopper.Exceptions;
using RockHopper.Mocking.Parameters;
using RockHopper.Mocking.Setup;

// ReSharper disable UnusedType.Global - Used by Mock object to find a setup
// ReSharper disable UnusedMember.Global - Used by Mock object to find a setup

namespace RockHopper.Mocking.Extensions;

public static class SetupInfoListExtensions
{
    public static SetupInfo FindBy(this List<SetupInfo> setupInfoList, MethodBase method, object?[]? args)
    {
        foreach (var setupInfo in setupInfoList.Where(d => d.Name == method.Name))
        {
            // Find all the in params to match against
            var parameters = setupInfo
                .Parameters
                .Where(p => p.Type == ParameterType.In)
                .ToArray();

            // No args and params - must be a match
            if (parameters.Length == 0 && (args?.Length ?? 0) == 0) return setupInfo;

            // Mismatch between args and params - we won't find a match
            if (args?.Length < parameters.Length) break;

            // Copy the input args to an array based upon the number of actual input params
            var inArgs = new object[parameters.Length];
            Array.Copy(args!, 0, inArgs, 0, inArgs.Length);

            if (parameters.IsMatchFor(inArgs))
                return setupInfo;
        }

        throw new StrictMockViolationException(method);
    }
}