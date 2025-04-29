# Deferred Returns

There are situations where you may not know the value to be returned whilst configuring the setup of a function or property.

In these situations, the Returns method is overloaded to accept a Func(Of T) input, where T is the return type of the function or property:

```c#
[Fact]
public void CalculateSumUsingDeferredValue_AddNumbers_ReturnsDeferredSumValue()
{
    var sum = 0;
    var testSubject = new TestSubject<CalculatorService>();
    CalculatorService calculatorService = testSubject;
    var calculator = testSubject.GetMock<Calculator>();
    calculator.Setup(c => c.Add(10, 20)).Returns(() => sum); // Set the deferred sum function
    sum = 30; // Now determine the value of sum

    var result = calculatorService.AddNumbers(10, 20);
    
    result.ShouldBe(sum);
}
```

From the above you can see that the mock of Add is configured to accept an anonymous function and, later the sum variable is set to 30.

The evaluation of the return function occurs at the point of which a matching setup is found and invoked, allowing control of the return value before the call is to be made.

This also works with deferred series functions. Below shows an example of a account service attempting to debit the same amount twice. The first time succeeds 
but the second one fails as the _cannotDebit_ flag is matched for the second call:

```c#
[Fact]
public void RepeatDeferredValue_Debit_ThrowsExceptionOnSecondReturnCall()
{
    const bool canDebit = true;
    const bool cannotDebit = false;
    var account = new Account { Number = "12345678", Value = 50 };
    var testSubject = new TestSubject<AccountService>();
    AccountService accountService = testSubject;
    var accountManager = testSubject.GetMock<IAccountManager>();
    accountManager.Setup(m => m.Find(account.Number)).Returns(account, account);
    accountManager.Setup(m => m.CanDebit(account, 50)).Returns(() => canDebit, () => cannotDebit);

    Should.NotThrow<Exception>(() => accountService.Debit(account.Number, 50));
    
    var exception = Should.Throw<Exception>(() => accountService.Debit(account.Number, 50));
    exception.Message.ShouldBe("Not enough money in account to debit amount.");
}
```