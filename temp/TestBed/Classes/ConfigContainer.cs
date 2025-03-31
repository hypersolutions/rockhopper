namespace TestBed.Classes;

public sealed class ConfigContainer
{
    private readonly IConfig _config;

    public ConfigContainer(IConfig config)
    {
        _config = config;
    }

    public bool Connect()
    {
        return _config.Connection == "localhost";
    }

    public void ConfigureConnection(string connection)
    {
        _config.Connection = connection;
    }
}