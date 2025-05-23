namespace RockHopper.Mocking.Verifies;

internal abstract class Occurs(int count)
{
    internal int Count { get; } = count;

    internal static Occurs Once() => new ExactOccurs(1);

    internal static Occurs Never() => new ExactOccurs(0);

    internal static Occurs Exactly(int count) => new ExactOccurs(count);

    internal static Occurs AtLeast(int count) => new CountOrMoreOccurs(count);

    internal abstract void Assert(string target, int actualCount);
}