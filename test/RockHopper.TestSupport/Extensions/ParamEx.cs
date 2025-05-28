using RockHopper.Mocking.Parameters;

namespace RockHopper.TestSupport.Extensions;

public static class ParamEx
{
    [ParameterMatcher(typeof(LessThanParameterMatcher))]
    public static int IsLessThan(int maxValue)
    {
        return 0;
    }
}