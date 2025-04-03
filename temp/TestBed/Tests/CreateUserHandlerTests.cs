using RockHopper;
using RockHopper.Mocking;
using RockHopper.Mocking.Parameters;
using TestBed.Classes;

namespace TestBed.Tests;

public class CreateUserHandlerTests
{
    private readonly CreateUserHandler _handler = TestContext.Current.Subject<CreateUserHandler>();
    private readonly Mock<ICommand<User>> _command = TestContext.Current.Mock<ICommand<User>>();
    private readonly Mock<Config> _config = TestContext.Current.Mock<Config>();

    [Test]
    public void WithName_Save_CreatesUser()
    {
        _config.Setup(c => c.Connection).Returns("localhost");
        _command.Setup(c => c.Save("localhost", Param.Is<User>(u => u.First == "Homer" && u.Last == "Simpson"))).OccursOnce();
        
        _handler.Save("Homer", "Simpson");
    }
}