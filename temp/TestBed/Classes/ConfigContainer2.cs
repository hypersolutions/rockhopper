namespace TestBed.Classes;

public sealed class ConfigContainer2
{
    private readonly Config _config;

    public ConfigContainer2(Config config)
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