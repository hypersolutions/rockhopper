namespace RockHopper.Test;

/// <summary>
/// Defines the contract for a post-test hook.
/// </summary>
public interface IPostTestHook
{
    /// <summary>
    /// Executes the post-test hook.
    /// </summary>
    /// <param name="context">Hook context</param>
    /// <returns>Task</returns>
    Task ExecuteAsync(HookContext context);
}