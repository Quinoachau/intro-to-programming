using Banking.Domain;

namespace Banking.Tests.MakingWithdrawals;
[Trait("Category", "Overdraft")]
public class OverdraftNotAllowed
{
    [Fact]
    public void OverdraftDoesNotDecreaseYourBalance()
    {
        // Given I have an account with X balance
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        // When I withdraw X+1 from that account
        try
        {
            account.Withdraw(openingBalance + .01M);
        }
        catch (Exception)
        {
        }
        // Then the account still has a balance of X
        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void AnOverdraftExceptionIsProvided()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        Assert.Throws<AccountOverdraftException>(() => account.Withdraw(openingBalance + .01M));

    }
}