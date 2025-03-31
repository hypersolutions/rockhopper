namespace TestBed.Classes;

public sealed class CreatePetHandler
{
    private readonly ICommand<Pet> _command;
    private readonly Config _config;

    public CreatePetHandler(ICommand<Pet> command, Config config)
    {
        _command = command;
        _config = config;
    }

    public void Save(string name, string type)
    {
        var connection = _config.Connection;
        var pet = new Pet(name, type);
        _command.Save(connection, pet);
    }
}