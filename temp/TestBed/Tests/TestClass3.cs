using RockHopper;
using RockHopper.Assertions;
using RockHopper.Mocking;
using TestBed.Classes;

namespace TestBed.Tests;

public class TestClass3
{
    private readonly ConfigContainer _configContainer = TestContext.Current.Subject<ConfigContainer>();
    private readonly Mock<IConfig> _config = TestContext.Current.Mock<IConfig>();

    [Test]
    public void IncorrectConnection_Connect_ReturnsFalse()
    {
        _config.Setup(c => c.Connection).Returns("unknown");

        var connected = _configContainer.Connect();
        
        connected.ShouldBeFalse();
    }
    
    [Test]
    public void CorrectConnection_Connect_ReturnsTrue()
    {
        _config.Setup(c => c.Connection).Returns("localhost");

        var connected = _configContainer.Connect();
        
        connected.ShouldBeTrue();
    }
    
    [Test]
    public void UpdateConnection_ConfigureConnection_SetsConfig()
    {
        _config.Setup(c => c.Connection, "test").OccursOnce(); // Auto-verify

        _configContainer.ConfigureConnection("test");
    }
}