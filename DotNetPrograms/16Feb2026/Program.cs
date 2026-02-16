using System;
using System.Collections;
using System.Linq;
class Program
{
    static void Main()
    {
        // Payment p = new CreditCardPayment();
        // p.ProcessPayment();
        // Employee e = new FullTimeEmp("Sanjana", 5000);
        // Console.WriteLine(e.GetSalary());
        // Employee s = new PartTimeEmp("Ashi", 1000, 6);
        // Console.WriteLine(s.GetSalary());
        // BankAccount b = new CheckingAccount();
        // b.Deposit(5000);
        // b.WithDraw(400);
        // BankAccount c = new SavingsAccount();
        // c.Deposit(1000);
        // c.WithDraw(50);
        // SortedDic.itemDetails["Laptop"] = 50;
        // SortedDic.itemDetails["Phone"] = 100;
        // SortedDic.itemDetails["Tablet"] = 20;
        // SortedDic.itemDetails["Watch"] = 50;
        // Console.WriteLine("Find item with sold count = 50...");
        // var found = SortedDic.FindItemDetails(50);
        // foreach(var item in found)
        // {
        //     Console.WriteLine(item.Key + "->" + item.Value);
        // }
        // Console.WriteLine("Min and Max sold items....");
        // var minMax = SortedDic.FindMinandMaxSoldItems();
        // if(minMax.Count > 0)
        // {
        //     Console.WriteLine("Min sold item: " + minMax[0]);
        //     Console.WriteLine("Max sold item: " + minMax[1]);
        // }
        // Console.WriteLine("Sorted by Sold Coun..t");
        // var sorted = SortedDic.SortByCount();
        // foreach(var item in sorted)
        // {
        //     Console.WriteLine(item.Key + " -> " + item.Value);
        // }
        CalculateNumbers.AddNumber(50);
        CalculateNumbers.AddNumber(50);
        CalculateNumbers.AddNumber(50);        
        CalculateNumbers.AddNumber(50);
        CalculateNumbers.AddNumber(50);
        double cgpa = CalculateNumbers.CalculateGPA();
        Console.WriteLine(cgpa);
        Console.WriteLine(CalculateNumbers.GetGrade(cgpa));
    }
}
