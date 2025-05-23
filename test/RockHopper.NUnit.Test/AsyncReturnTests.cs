using NUnit.Framework;
using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport.Users;

namespace RockHopper.NUnit.Test;

public class AsyncReturnTests
{
    private UserService _userService;
    private Mock<IUserRepository> _userRepository;

    [SetUp]
    public void BeforeEachTest()
    {
        _userService = TestSubject.Create<UserService>();
        _userRepository = _userService.GetMock<IUserRepository>();
    }
    
    [Test]
    public async Task UnknownUserId_FindUserAsync_ThrowsException()
    {
        const int userId = 1;
        _userRepository.Function(r => r.GetUserAsync(userId)).Returns((User?)null);

        var exception = await Should.ThrowAsync<Exception>(() => _userService.FindUserAsync(userId));

        exception.Message.ShouldBe($"Unable to find a user for {userId}.");
    }
    
    [Test]
    public async Task KnownUserId_FindUserAsync_ReturnsUser()
    {
        var user = new User { Id = 1, Name = "Homer Simpson" };
        _userRepository.Function(r => r.GetUserAsync(user.Id)).Returns(user);
        
        var foundUser = await _userService.FindUserAsync(user.Id);

        foundUser.ShouldBe(user);
    }
    
    [Test]
    public async Task WithUser_SaveUserAsync_CallsSaveOnRepository()
    {
        var user = new User { Id = 1, Name = "Homer Simpson" };
        _userRepository.Function(r => r.SaveAsync(user)).Returns(Task.CompletedTask);
        
        await _userService.SaveUserAsync(user);

        _userService.VerifyAll();
    }
    
    [Test]
    public async Task KnownUser_UserExistsAsync_CallsSaveOnRepository()
    {
        const int userId = 1;
        _userRepository.Function(r => r.UserExistsAsync(userId)).Returns(true);
        
        var result = await _userService.UserExistsAsync(userId);

        result.ShouldBeTrue();
    }
}