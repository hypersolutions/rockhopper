using System.Linq.Expressions;
using RockHopper.Assertions;
using RockHopper.Mocking.Parameters;

namespace RockHopper.Test.Mocking.Parameters;

public class ParameterMatcherFactoryTests 
{
    [Test]
    public void ConstantExpression_Create_ReturnsExactMatcher()
    {
        Expression<Func<int>> expression = () => 10;

        var matcher = ParameterMatcherFactory.Create(expression, 10);

        matcher.ShouldBeOfType<ExactParameterMatcher>();
    }

    [Test]
    public void PredicateExpression_Create_ReturnsPredicateMatcher()
    {
        Expression<Func<int>> expression = () => Param.Is<int>(p => p < 10);

        var matcher = ParameterMatcherFactory.Create(expression, null);

        matcher.ShouldBeOfType<PredicateParameterMatcher>();
    }

    [Test]
    public void AnyExpression_Create_ReturnsAnyMatcher()
    {
        Expression<Func<int>> expression = () => Param.IsAny<int>();

        var matcher = ParameterMatcherFactory.Create(expression, null);

        matcher.ShouldBeOfType<AnyParameterMatcher>();
    }

    [Test]
    public void RegexExpression_Create_ReturnsRegexMatcher()
    {
        Expression<Func<string>> expression = () => Param.IsRegex("^[0-9]{8}$");

        var matcher = ParameterMatcherFactory.Create(expression, null);

        matcher.ShouldBeOfType<RegexParameterMatcher>();
    }
}