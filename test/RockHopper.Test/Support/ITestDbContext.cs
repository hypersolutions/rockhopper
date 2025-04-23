namespace RockHopper.Test.Support;

public interface ITestDbContext
{
    bool Save<TEntity>(TEntity entity, string connection);
}