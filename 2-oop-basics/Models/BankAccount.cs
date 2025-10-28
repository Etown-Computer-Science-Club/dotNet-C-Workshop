namespace Workshop.Models;

public class BankAccount
{
    public string Owner { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal initialBalance)
    {
        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0) throw new ArgumentException("Amount must be positive");
        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0) return false;
        if (amount > Balance) return false;
        Balance -= amount;
        return true;
    }

    public override string ToString() => $"{Owner} has {Balance:C}";
}
