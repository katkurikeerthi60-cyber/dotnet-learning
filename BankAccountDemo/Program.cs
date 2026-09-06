BankAccount account = new BankAccount("Keerthi", 1000);

Console.WriteLine($"Account Holder: {account.AccountHolder}");
Console.WriteLine($"Initial Balance: {account.Balance}");

account.Deposit(500);
account.Withdraw(200);

Console.WriteLine($"Final Balance: {account.Balance}");

account.Withdraw(2000);

public class BankAccount
{
    public string AccountHolder { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        AccountHolder = accountHolder;

        if (initialBalance >= 0)
        {
            Balance = initialBalance;
        }
        else
        {
            Balance = 0;
            Console.WriteLine("Initial balance cannot be negative.");
        }
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be greater than zero.");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
    }
}