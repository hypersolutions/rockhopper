namespace RockHopper;

/// <summary>
/// Defines the contract for a class fixture.
/// </summary>
public interface IClassFixture : IAsyncDisposable
{
    /// <summary>
    /// Execute the fixture.
    /// </summary>
    /// <returns>Async task</returns>
    Task ExecuteAsync();
}