namespace RockHopper;

/// <summary>
/// Defines the contract for a pre-test hook.
/// </summary>
public interface IPreTestHook
{
    /// <summary>
    /// Executes the pre-test hook.
    /// </summary>
    /// <param name="context">Hook context</param>
    /// <returns>Task</returns>
    Task ExecuteAsync(HookContext context);
}