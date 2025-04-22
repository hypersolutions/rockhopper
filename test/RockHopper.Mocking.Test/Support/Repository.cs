namespace RockHopper.Mocking.Test.Support;

public sealed class TestRepository
{
    private readonly ITestDbContext _dbContext;
    private readonly TestConfig _config;

    public TestRepository(ITestDbContext dbContext, TestConfig config)
    {
        _dbContext = dbContext;
        _config = config;
    }
    
    public ITestLogger? Logger { get; set; }

    public bool Save<TEntity>(TEntity entity)
    {
        return _dbContext.Save(entity, _config.Connection);
    }
}

public interface ITestDbContext
{
    bool Save<TEntity>(TEntity entity, string connection);
}

public abstract class TestConfig
{
    public abstract string Connection { get; }
}

public interface ITestLogger
{
    void Log(string message);
}

public sealed class TestUser;