

using Banking.Domain;
using Banking.Domain.DomainExceptions;

namespace Banking.Tests.MakingDeposits;
public class DepositsIncreaseBalance
{
    [Theory]
    [InlineData(110.10)]
    [InlineData(0.25)]
    [Trait("Category", "Deposit")]
    public void MakingADeposit(decimal amountToDeposit)
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());

    }
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [Trait("Category", "Deposit")]
    public void InvalidAmountsCannotBeDeposited(decimal amountToDeposit)
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        
        Assert.Throws<InvalidTransactionAmountException>(() => account.Deposit(amountToDeposit));
        Assert.Equal(openingBalance, account.GetBalance());
    }
}
