namespace RockHopper.Test.Engine.Fixtures;

internal class SharedFixtureInfo(ISharedFixture fixture)
{
    private readonly List<Type> _testClassTypes = [];

    internal ISharedFixture Fixture { get; } = fixture;

    internal void AddType(Type testClassType)
    {
        if (!_testClassTypes.Contains(testClassType))
        {
            _testClassTypes.Add(testClassType);
        }
    }

    internal bool ContainsTestClassType(Type testClassType)
    {
        return _testClassTypes.Contains(testClassType);
    }

    internal bool ContainsFixtureType(Type fixtureType)
    {
        return Fixture.GetType() == fixtureType;
    }
}