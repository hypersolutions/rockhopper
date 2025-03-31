namespace TestBed.Classes;

public sealed class CreateUserHandler
{
    private readonly ICommand<User> _command;
    private readonly Config _config;

    public CreateUserHandler(ICommand<User> command, Config config)
    {
        _command = command;
        _config = config;
    }

    public void Save(string first, string last)
    {
        var connection = _config.Connection;
        var user = new User(first, last);
        _command.Save(connection, user);
    }
}