using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string msg) : base(msg) { }
}

public class EcommerceApplication
{
    protected int Balance = 5000;
    public void Withdraw(int amount)
    {
        if(amount < Balance)
        {
            Balance -= amount;
            Console.WriteLine("Remaining balance: " + Balance);
            Console.WriteLine("Withdrawn amount: " + amount);
        }
        else
        {
            throw new InsufficientBalanceException("Insufficient Balance");
        }
    }
}
