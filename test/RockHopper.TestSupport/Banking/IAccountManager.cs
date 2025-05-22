namespace RockHopper.TestSupport.Banking;

public interface IAccountManager
{
    Account? Find(string accountNumber);
    bool CanDebit(Account account, decimal amount);
}