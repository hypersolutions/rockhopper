using Microsoft.Testing.Platform.Configurations;
using RockHopper.Test.Exceptions;

namespace RockHopper.Test.Engine;

internal sealed class TestConfigurationProvider : ITestConfiguration
{
    private readonly IConfiguration _configuration;

    internal TestConfigurationProvider(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public T? Get<T>(string key)
    {
        var value = _configuration[key];
        return value is not null ? ConvertTo<T>(value) : default;
    }
    
    private static T ConvertTo<T>(string value)
    {
        try
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
        catch (Exception error)
        {
            throw new TestException($"Unable to convert the string value to {typeof(T)}.", error);
        }
    }
}