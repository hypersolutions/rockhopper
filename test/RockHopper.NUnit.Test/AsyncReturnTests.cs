using NUnit.Framework;
using RockHopper.Assertions;
using RockHopper.Mocking;
using RockHopper.TestSupport;

namespace RockHopper.NUnit.Test;

public class AsyncReturnTests
{
    private UserService _userService;
    private Mock<IUserRepository> _userRepository;

    [SetUp]
    public void BeforeEachTest()
    {
        var testSubject = new TestSubject<UserService>();
        _userService = testSubject;
        _userRepository = testSubject.GetMock<IUserRepository>();
    }
    
    [Test]
    public async Task UnknownUserId_FindUserAsync_ThrowsException()
    {
        const int userId = 1;
        _userRepository.Function(r => r.GetUserAsync(userId)).ReturnsAsync((User?)null);

        var exception = await Should.ThrowAsync<Exception>(() => _userService.FindUser(userId));

        exception.Message.ShouldBe($"Unable to find a user for {userId}.");
    }
    
    [Test]
    public async Task KnownUserId_FindUserAsync_ReturnsUser()
    {
        var user = new User { Id = 1, Name = "Homer Simpson" };
        _userRepository.Function(r => r.GetUserAsync(user.Id)).ReturnsAsync(user);
        
        var foundUser = await _userService.FindUser(user.Id);

        foundUser.ShouldBe(user);
    }
}