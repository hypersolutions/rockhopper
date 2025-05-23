namespace RockHopper.TestSupport.Users;

public interface IUserRepository
{
    ValueTask<bool> UserExistsAsync(int id);
    Task<User?> GetUserAsync(int id);
    Task SaveAsync(User user);
}