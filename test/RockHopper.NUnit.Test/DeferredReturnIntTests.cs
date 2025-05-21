using NUnit.Framework;
using RockHopper.Assertions;
using RockHopper.TestSupport;

// ReSharper disable AccessToModifiedClosure - Deferred test setup example

namespace RockHopper.NUnit.Test;

public class DeferredReturnIntTests
{
    [Test]
    public void CalculateSumUsingDeferredValue_AddNumbers_ReturnsDeferredSumValue()
    {
        var sum = 0;
        var calculatorService = TestSubject.Create<CalculatorService>();
        var calculator = calculatorService.GetMock<Calculator>();
        calculator.Function(c => c.Add(10, 20)).Returns(() => sum);

        sum = 30;

        var result = calculatorService.AddNumbers(10, 20);
        
        result.ShouldBe(sum);
    }
    
    [Test]
    public void RepeatDeferredValue_Debit_ThrowsExceptionOnSecondReturnCall()
    {
        const bool canDebit = true;
        const bool cannotDebit = false;
        var account = new Account { Number = "12345678", Value = 50 };
        var accountService = TestSubject.Create<AccountService>();
        var accountManager = accountService.GetMock<IAccountManager>();
        accountManager.Function(m => m.Find(account.Number)).Returns(account, account);
        accountManager.Function(m => m.CanDebit(account, 50)).Returns(() => canDebit, () => cannotDebit);

        Should.NotThrow<Exception>(() => accountService.Debit(account.Number, 50));
        
        var exception = Should.Throw<Exception>(() => accountService.Debit(account.Number, 50));
        exception.Message.ShouldBe("Not enough money in account to debit amount.");
    }
}