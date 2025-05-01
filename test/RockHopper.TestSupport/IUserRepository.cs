namespace RockHopper.TestSupport;

public interface IUserRepository
{
    Task<User?> GetUserAsync(int id);
}