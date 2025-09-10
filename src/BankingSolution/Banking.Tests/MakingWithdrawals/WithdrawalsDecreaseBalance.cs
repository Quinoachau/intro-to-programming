

using Banking.Domain;

namespace Banking.Tests.MakingWithdrawals;

public class WithdrawalsDecreaseBalance()
{
    [Theory]
    [InlineData(110.10)]
    [InlineData(0.25)]
    public void MakingAWithdrawal(decimal amountToWithdraw)
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }
}
