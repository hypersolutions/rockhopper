using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport;

namespace RockHopper.XUnit.Test;

public class AsyncReturnTests
{
    private readonly UserService _userService;
    private readonly Mock<IUserRepository> _userRepository;

    public AsyncReturnTests()
    {
        var testSubject = new TestSubject<UserService>();
        _userService = testSubject;
        _userRepository = testSubject.GetMock<IUserRepository>();
    }
    
    [Fact]
    public async Task UnknownUserId_FindUserAsync_ThrowsException()
    {
        const int userId = 1;
        _userRepository.Function(r => r.GetUserAsync(userId)).ReturnsAsync((User?)null);

        var exception = await Should.ThrowAsync<Exception>(() => _userService.FindUser(userId));

        exception.Message.ShouldBe($"Unable to find a user for {userId}.");
    }
    
    [Fact]
    public async Task KnownUserId_FindUserAsync_ReturnsUser()
    {
        var user = new User { Id = 1, Name = "Homer Simpson" };
        _userRepository.Function(r => r.GetUserAsync(user.Id)).ReturnsAsync(user);
        
        var foundUser = await _userService.FindUser(user.Id);

        foundUser.ShouldBe(user);
    }
}