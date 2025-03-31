using RockHopper;
using RockHopper.Mocking;
using RockHopper.Mocking.Parameters;
using TestBed.Classes;

namespace TestBed.Tests;

public class CreatePetHandlerAltTests
{
    private readonly CreatePetHandler _handler = TestContext.Subject<CreatePetHandler>();
    private readonly Mock<ICommand<Pet>> _command = TestContext.Mock<ICommand<Pet>>();
    private readonly Mock<Config> _config = TestContext.Mock<Config>();

    [Test]
    public void WithNameAndType_Save_CreatesPet()
    {
        _config.Setup(c => c.Connection).Returns("localhost");
        _command.Setup(c => c.Save("localhost", Param.Is<Pet>(u => u.Name == "Tiddles" && u.Type == "Cat"))).OccursOnce();
        
        _handler.Save("Tiddles", "Cat");
    }

    public async ValueTask DisposeAsync()
    {
        Console.WriteLine("After");
        await Task.CompletedTask;
    }
}