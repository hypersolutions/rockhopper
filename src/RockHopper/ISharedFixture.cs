namespace RockHopper;

/// <summary>
/// Defines the contract for a shared fixture.
/// </summary>
public interface ISharedFixture : IAsyncDisposable
{
    /// <summary>
    /// Execute the fixture.
    /// </summary>
    /// <returns>Async task</returns>
    Task ExecuteAsync();
}