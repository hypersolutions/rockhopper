using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport;

namespace RockHopper.XUnit.Test;

public class AsyncReturnTests
{
    private readonly UserService _userService;
    private readonly Mock<IUserRepository> _userRepository;
    private readonly TestSubject<UserService> _testSubject;

    public AsyncReturnTests()
    {
        _testSubject = new TestSubject<UserService>();
        _userService = _testSubject;
        _userRepository = _testSubject.GetMock<IUserRepository>();
    }
    
    [Fact]
    public async Task UnknownUserId_FindUserAsync_ThrowsException()
    {
        const int userId = 1;
        _userRepository.Function(r => r.GetUserAsync(userId)).ReturnsAsync((User?)null);

        var exception = await Should.ThrowAsync<Exception>(() => _userService.FindUserAsync(userId));

        exception.Message.ShouldBe($"Unable to find a user for {userId}.");
    }
    
    [Fact]
    public async Task KnownUserId_FindUserAsync_ReturnsUser()
    {
        var user = new User { Id = 1, Name = "Homer Simpson" };
        _userRepository.Function(r => r.GetUserAsync(user.Id)).ReturnsAsync(user);
        
        var foundUser = await _userService.FindUserAsync(user.Id);

        foundUser.ShouldBe(user);
    }
    
    [Fact]
    public async Task WithUser_SaveUserAsync_CallsSaveOnRepository()
    {
        var user = new User { Id = 1, Name = "Homer Simpson" };
        _userRepository.Function(r => r.SaveAsync(user)).Returns(Task.CompletedTask);
        
        await _userService.SaveUserAsync(user);

        _testSubject.VerifyAll();
    }
}