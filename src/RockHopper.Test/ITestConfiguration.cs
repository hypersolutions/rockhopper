namespace RockHopper.Test;

/// <summary>
/// Defines the configuration access helper.
/// </summary>
public interface ITestConfiguration
{
    /// <summary>
    /// Gets a value fro the key.
    /// </summary>
    /// <param name="key">Key such as X or X:Y etc</param>
    /// <typeparam name="T">Type to convert value to</typeparam>
    /// <returns>Value as type requested or throws exception if unable to convert</returns>
    T? Get<T>(string key);
}