
using Banking.Domain.DomainExceptions;
namespace Banking.Domain;

public class BankAccount
{
    private decimal balance = 5000M;
    public void Deposit(TransactionAmount amountToDeposit)
    {
        balance += amountToDeposit;
    }
    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw <= 0)
        {
            throw new InvalidTransactionAmountException();
        }
        if (amountToWithdraw <= balance)
        {
            balance -= amountToWithdraw;
        } else
        {
            throw new AccountOverdraftException();
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
