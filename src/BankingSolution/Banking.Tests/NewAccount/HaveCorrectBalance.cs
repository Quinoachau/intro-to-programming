
using Banking.Domain;

namespace Banking.Tests.NewAccount;
public class HaveCorrectBalance
{
    [Fact]
    public void CorrectBalanceForNewAccounts()
    {
        // Given i have a new bank account
        var account = new BankAccount();

        // When i ask that account for the balance
        decimal balance = account.GetBalance();

        //Then it should be ...

        Assert.Equal(5000M, balance);
    }
}
