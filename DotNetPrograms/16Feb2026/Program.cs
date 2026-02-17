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
        // CalculateNumbers.AddNumber(50);
        // CalculateNumbers.AddNumber(50);
        // CalculateNumbers.AddNumber(50);        
        // CalculateNumbers.AddNumber(50);
        // CalculateNumbers.AddNumber(50);
        // double cgpa = CalculateNumbers.CalculateGPA();
        // Console.WriteLine(cgpa);
        // Console.WriteLine(CalculateNumbers.GetGrade(cgpa));
        // MovieManager mg = new MovieManager();
        // Console.WriteLine("Enter no of moives: ");
        // int n = int.Parse(Console.ReadLine());
        // for(int i = 0; i < n; i++)
        // {
        //     string[] input = Console.ReadLine().Split(",");
        //     if(input.Length != 3)
        //     {
        //         continue;
        //     }
        //     Movie m = new Movie()
        //     {
        //         Title = input[0],
        //         Genre = input[1],
        //         Rating = double.Parse(input[2])
        //     };
        //     mg.AddMovie(m);
        // }
        // var film = mg.FilterByGenre("Action");
        // foreach(var item in film)
        // {
        //     Console.WriteLine($"{item.Title} : {item.Genre} : {item.Rating}");
        // }
        // var sorting = mg.SortByRating();
        // foreach(var item in sorting)
        // {
        //     Console.WriteLine($"{item.Title2} : {item.Genre} : {item.Rating}");
        //}
        YogaCenter yc = new YogaCenter();
        Member m = new Member("Sanjana", 21, 1.65, 55, "WeightLoss");
        yc.AddMember(m);
        Member m1 = new Member("Ashi", 22, 1.0, 45, "Fitness");
        yc.AddMember(m1);
        Member m2 = new Member("Raima", 22, 1.5, 50, "Therapy");
        yc.AddMember(m2);
        yc.DisplayMembers();
    }
}
