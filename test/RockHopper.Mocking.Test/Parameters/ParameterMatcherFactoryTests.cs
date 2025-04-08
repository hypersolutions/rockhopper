using System.Linq.Expressions;
using RockHopper.Assertions;
using RockHopper.Mocking.Parameters;

namespace RockHopper.Mocking.Test.Parameters;

public class ParameterMatcherFactoryTests 
{
    [Fact]
    public void ConstantExpression_Create_ReturnsExactMatcher()
    {
        Expression<Func<int>> expression = () => 10;

        var matcher = ParameterMatcherFactory.Create(expression, 10);

        matcher.ShouldBeOfType<ExactParameterMatcher>();
    }

    [Fact]
    public void PredicateExpression_Create_ReturnsPredicateMatcher()
    {
        Expression<Func<int>> expression = () => Param.Is<int>(p => p < 10);

        var matcher = ParameterMatcherFactory.Create(expression, null);

        matcher.ShouldBeOfType<PredicateParameterMatcher>();
    }

    [Fact]
    public void AnyExpression_Create_ReturnsAnyMatcher()
    {
        Expression<Func<int>> expression = () => Param.IsAny<int>();

        var matcher = ParameterMatcherFactory.Create(expression, null);

        matcher.ShouldBeOfType<AnyParameterMatcher>();
    }

    [Fact]
    public void RegexExpression_Create_ReturnsRegexMatcher()
    {
        Expression<Func<string>> expression = () => Param.IsRegex("^[0-9]{8}$");

        var matcher = ParameterMatcherFactory.Create(expression, null);

        matcher.ShouldBeOfType<RegexParameterMatcher>();
    }
}