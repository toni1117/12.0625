﻿namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        BankAccount acc = new BankAccount();
        acc.ID = 1;
        acc.Deposit(15);
        acc.Withdraw(5);

        Console.WriteLine(acc.ToString());
    }
}