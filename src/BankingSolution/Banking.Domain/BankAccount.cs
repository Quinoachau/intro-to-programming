

namespace Banking.Domain;

public class BankAccount
{
    private decimal balance = 5000M;
    public void Deposit(decimal amountToDeposit)
    {
       balance = balance + amountToDeposit;
    }
    public void Withdraw(decimal amountToWithdraw)
    {
        balance = balance - amountToWithdraw;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}