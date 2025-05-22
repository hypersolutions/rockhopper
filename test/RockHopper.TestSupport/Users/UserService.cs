namespace RockHopper.TestSupport.Users;

public sealed class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> FindUserAsync(int id)
    {
        var user = await _userRepository.GetUserAsync(id);

        return user ?? throw new Exception($"Unable to find a user for {id}.");
    }

    public async Task SaveUserAsync(User user)
    {
        await _userRepository.SaveAsync(user);
    }
}