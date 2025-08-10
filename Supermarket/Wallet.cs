namespace Supermarket.System;

public class Wallet
{
    public decimal Balance { get; private set; }

    public Wallet(decimal initialAmount)
    {
        Balance = initialAmount;
    }

    public bool HasEnough(decimal amount) => Balance >= amount;

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new InvalidOperationException("Недостаточно средств.");
        }
        Balance -= amount;
    }
}