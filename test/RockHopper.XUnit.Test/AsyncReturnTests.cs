using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport.Users;

namespace RockHopper.XUnit.Test;

public class AsyncReturnTests
{
    private readonly UserService _userService;
    private readonly Mock<IUserRepository> _userRepository;

    public AsyncReturnTests()
    {
        _userService = TestSubject.Create<UserService>();
        _userRepository = _userService.GetMock<IUserRepository>();
    }
    
    [Fact]
    public async Task UnknownUserId_FindUserAsync_ThrowsException()
    {
        const int userId = 1;
        _userRepository.Function(r => r.GetUserAsync(userId)).Returns((User?)null);

        var exception = await Should.ThrowAsync<Exception>(() => _userService.FindUserAsync(userId));

        exception.Message.ShouldBe($"Unable to find a user for {userId}.");
    }
    
    [Fact]
    public async Task KnownUserId_FindUserAsync_ReturnsUser()
    {
        var user = new User { Id = 1, Name = "Homer Simpson" };
        _userRepository.Function(r => r.GetUserAsync(user.Id)).Returns(user);
        
        var foundUser = await _userService.FindUserAsync(user.Id);

        foundUser.ShouldBe(user);
    }
    
    [Fact]
    public async Task WithUser_SaveUserAsync_CallsSaveOnRepository()
    {
        var user = new User { Id = 1, Name = "Homer Simpson" };
        _userRepository.Function(r => r.SaveAsync(user)).Returns(Task.CompletedTask);
        
        await _userService.SaveUserAsync(user);

        _userService.VerifyAll();
    }
    
    [Fact]
    public async Task KnownUser_UserExistsAsync_CallsSaveOnRepository()
    {
        const int userId = 1;
        _userRepository.Function(r => r.UserExistsAsync(userId)).Returns(true);
        
        var result = await _userService.UserExistsAsync(userId);

        result.ShouldBeTrue();
    }
}