using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string msg) : base(msg){ }
}
public class MinimumBalanceException : Exception
{
    public MinimumBalanceException(string msg) : base(msg){ }
}
public class InvalidTransactionException : Exception
{
    public InvalidTransactionException(string msg) : base(msg){ }
}
public abstract class BankAccount
{
    public string AccountNumber{get; set;}
    public string CustomerName{get; set;}
    public double Balance{get; set;}
    public List<string> Transaction = new List<string>();
    protected BankAccount(string acc, string name, double bal)
    {
        AccountNumber = acc;
        CustomerName = name;
        Balance = bal;
    }
    public virtual void Deposit(double amount)
    {
        if(amount < 0)
        {
            throw new InvalidTransactionException("Invalid deposit amount");
        }
        else
        {
            Balance += amount;
            Transaction.Add($"Deposited amount: {amount}");
            Console.WriteLine($"Deposited amount: {amount} - Current Balance: {Balance}");
        }
    }
    public virtual void Withdraw(double amount)
    {
        if(amount > Balance)
        {
            throw new InsufficientBalanceException ("Not enough Balance");
        }
        else
        {
            Balance -= amount;
            Transaction.Add($"Withdrawn Amount: {amount}");
            Console.WriteLine($"Withdrawn Amount: {amount} - Current Balance: {Balance}");
        }
    }
    public abstract double CalculateInterest();
}
public class SavingsAccount : BankAccount
{
    private const double MinBalance = 1000;
    public SavingsAccount(string a, string n, double b) : base(a, n, b){ }
    public override void Withdraw(double amount)
    {
        if(Balance - amount < MinBalance)
        {
            throw new MinimumBalanceException("Minimum balance required");
        }
        base.Withdraw(amount);
    }
    public override double CalculateInterest()
    {
        return Balance * 0.04;
    }
}
public class CurrentAccount : BankAccount
{
    private const double Overdraft = 5000;
    public CurrentAccount(string a, string n, double b) : base(a, n, b) { }
    public override void Withdraw(double amount)
    {
        if(Balance -  amount < -Overdraft)
        {
            throw new InsufficientBalanceException("Overdraft exceeded");
        }
        base.Withdraw(amount);
    }
    public override double CalculateInterest()
    {
        return 0;
    }
}
public class LoanAccount : BankAccount
{
    public LoanAccount(string a, string n, double b) : base(a, n, b) { }
    public override void Deposit(double amount)
    {
        throw new InvalidTransactionException("Cannot deposit into loan");
    }
    public override double CalculateInterest()
    {
        return Balance * 0.1;
    }
}
public class BankSystem
{
    public List<BankAccount> Accounts = new List<BankAccount>();
    public void Transfer(BankAccount from, BankAccount to, double amount)
    {
        from.Withdraw(amount);
        to.Deposit(amount);
    }
    public void RunReports()
    {
        Console.WriteLine("Account > 50K:");
        var big = Accounts.Where(a => a.Balance > 50000);
        foreach(var v in big)
        {
            Console.WriteLine(a.CustomerName);
        }

        Console.WriteLine("Total Bank Balance");
        Console.WriteLine(Accounts.Sum(a => a.Balance));

        Console.WriteLine("Top 3 accounts:");
        var top = Accounts.OrderByDescending(a => a.Balance).Take(3);
        foreach(var a in top)
        {
            Console.WriteLine(a.CustomerName);
        }

        Console.WriteLine("Grouped by type:");
        var groups = Accounts.GroupBy(a => a.GetType().Name);
        foreach(var g in groups)
        {
            Console.WriteLine($"{g.Key} : {g.Count()}");
        }
        Console.WriteLine("Names starting with R:");
        var r =  Accounts.Where(a => a.CustomerName.StartsWith("R"));
        foreach(var a in r)
        {
            Console.WriteLine(a.CustomerName);
        }
    }
}