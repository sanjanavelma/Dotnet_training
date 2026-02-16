using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BankAccount
{
    protected double Balance;
    public virtual void Deposit(int amount)
    {
        Balance += amount;
        Console.WriteLine("Deposited amount: " + amount);
        Console.WriteLine("Balance: " + Balance);
    }  
    public virtual void WithDraw(int amount)
    {
        Balance -= amount;
        Console.WriteLine("Withdrawn amount: " + amount);
        Console.WriteLine("Balance: " + Balance);
    }  
}
public class CheckingAccount : BankAccount
{
    public override void WithDraw(int amount)
    {
        if(Balance - amount < 0)
        {
            Console.WriteLine("Insufficient Balance");
        }
        else
        {
            base.WithDraw(amount);
        }
    }
}
public class SavingsAccount : BankAccount
{
    private double rate = 0.05;
    public override void Deposit(int amount)
    {
        Balance += amount + (amount * rate);
        Console.WriteLine("Deposited with interest: " + amount * rate);
    }
}
