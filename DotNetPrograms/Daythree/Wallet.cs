using System;
class Wallet
{
    private double money = 500;
    public void AddMoney(double amount)
    {
        //Console.WriteLine("Enter the amount: ");
        //double amount = Convert.ToDouble(Console.ReadLine());
        money += amount;
    }
    public double GetBalance()
    {
        return money;
    }
}