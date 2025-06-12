namespace ConsoleApp1;

public class BankAccount
{
    private int id;
    private double balance;
    
    public int ID
    {
        get => id;
        set => id = value;
    }
    
    public double Balance => balance;
    
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
    
    public void Withdraw(double amount)
    {
        if (amount <= balance && amount > 0)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }
    
    public override string ToString()
    {
        return $"Account ID{ID}, balance {Balance:F2}";
    }
}