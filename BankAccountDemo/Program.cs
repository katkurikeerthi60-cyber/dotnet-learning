using System;

try
{
    BankAccount account = new BankAccount("Keerthi", 1000);

    Console.WriteLine($"Account Holder: {account.AccountHolder}");
    Console.WriteLine($"Initial Balance: {account.Balance}");

    account.Deposit(500);
    Console.WriteLine($"Balance after deposit: {account.Balance}");

    account.Withdraw(200);
    Console.WriteLine($"Balance after withdrawal: {account.Balance}");

    account.Withdraw(2000);
}
catch (InsufficientFundsException ex)
{
    Console.WriteLine($"Transaction failed: {ex.Message}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Invalid input: {ex.Message}");
}
finally
{
    Console.WriteLine("Transaction processing completed.");
}

public class BankAccount
{
    public string AccountHolder { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        if (string.IsNullOrWhiteSpace(accountHolder))
        {
            throw new ArgumentException("Account holder name is required.");
        }

        if (initialBalance < 0)
        {
            throw new ArgumentException("Initial balance cannot be negative.");
        }

        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }

        Balance += amount;
        Console.WriteLine($"Deposited: {amount}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.");
        }

        if (amount > Balance)
        {
            throw new InsufficientFundsException(
                $"Insufficient funds. Available balance: {Balance}, requested: {amount}"
            );
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}");
    }
}

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message)
        : base(message)
    {
    }
}