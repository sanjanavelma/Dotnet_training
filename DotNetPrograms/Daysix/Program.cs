using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        /*StockPrice SP = new StockPrice
        {
            StockSymbol = "AAPL",
            Price = 150.50
        };
        StockPrice copySP = SP;
        copySP.Price = 155.00;
        Trade T = new Trade
        {
            TradeId = 1,
            StockSymbol = "AAPL",
            Quantity = 100
        };
        Trade T2 = T;
        T2.Quantity = 200;
        Console.WriteLine($"Original Stock Price: {SP.Price}"); 
        Console.WriteLine($"Copied Stock Price: {copySP.Price}");
        Console.WriteLine($"Original Trade Quantity: {T.Quantity}");
        Console.WriteLine($"Copied Trade Quantity: {T2.Quantity}");*/
        //=============================================================//
        // Portfolio p1 = new Portfolio { Name = "Growth" };
        // Portfolio p2 = new Portfolio { Name = "Growth" };
        // Console.WriteLine(p1.Equals(p2));
        // int a = p1.GetHashCode();
        // int b = p2.GetHashCode();
        // Console.WriteLine(a); //if we use == it will give false because it will check reference
        // Console.WriteLine(b);
        //=============================================================================//
        // Trade t = new EquityTrade();
        // Console.WriteLine(t.GetType());
        //==========================================================================//
        // Repository<Customer> TR = new Repository<Customer>();
        // TR.Data = new Customer{Name = "Sathvika"};
        // Console.WriteLine(TR.Data.Name);
        //=======================================================================//
        Calculator C = new Calculator();
        int result = C.Calculate(4 , 5);
        Console.WriteLine(result);
        Console.WriteLine(C.Calculate(4 , 5.5));
        //====================================================================//
    }
}