namespace RockHopper.TestSupport.Users;

public interface IUserRepository
{
    Task<User?> GetUserAsync(int id);
    Task SaveAsync(User user);
}