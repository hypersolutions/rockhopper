namespace RockHopper;

/// <summary>
/// Defines the contract for an assembly fixture.
/// </summary>
public interface IAssemblyFixture : IAsyncDisposable
{
    /// <summary>
    /// Execute the fixture.
    /// </summary>
    /// <returns>Async task</returns>
    Task ExecuteAsync();
}