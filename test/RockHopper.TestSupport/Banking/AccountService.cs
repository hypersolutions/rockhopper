namespace RockHopper.TestSupport.Banking;

public sealed class AccountService
{
    private readonly IAccountManager _accountManager;

    public AccountService(IAccountManager accountManager)
    {
        _accountManager = accountManager;
    }
    
    public void Debit(string accountNumber, decimal amount)
    {
        var account = _accountManager.Find(accountNumber);

        if (account is null)
            throw new Exception("Account not found.");

        if (!_accountManager.CanDebit(account, amount))
            throw new Exception("Not enough money in account to debit amount.");
        
        account.Value -= amount;
    }
}