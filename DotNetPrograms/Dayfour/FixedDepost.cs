using System;

class BankAccount
{
    public double balance;
    public int accNum;

    public BankAccount(double bal, int acc)
    {
        this.balance = bal;
        this.accNum = acc;
        Console.WriteLine("Bank Account Created");
    }
}

class FixedDeposit : BankAccount
{
    // public int timePeriod;
    // public double fdAmount;
    // public double roi;

    public FixedDeposit() : base(40000, 101)
    {
        Console.WriteLine($"Fixed Deposit Created for {this.accNum} amount {this.balance}");
    }
}
