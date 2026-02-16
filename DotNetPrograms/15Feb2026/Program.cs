using System;
using System.Collections;
using System.Linq;
// class Person()
// {
//     public virtual void GetDetails()
//     {
//         Console.WriteLine("This is a person.");
//     }
// }
// class Student : Person
// {
//     public override void GetDetails()
//     {
//         Console.WriteLine($"This is a student.");
//     }
// }
// class Employee
// {
//     public virtual int CalculateSalary()
//     {
//         return 40000;
//     }
// }
// class Manager : Employee
// {
//     public override int CalculateSalary()
//     {
//         return base.CalculateSalary() + 1000;
//     }
// }
// public class Vehicle
// {
//     public virtual void StartEngine()
//     {
//         Console.WriteLine("Vehicle Started");
//     }
// }
// class Car : Vehicle
// {
//     public override void StartEngine()
//     {
//         Console.WriteLine("Car started");
//     }
// }
// class Motorcycle : Vehicle
// {
//     public override void StartEngine()
//     {
//         Console.WriteLine("Motorcycle started");
//     }
// }
// class BankAccount
// {
//     protected double balance;
//     public virtual void Deposit(int amount)
//     {
//         balance += amount;
//         Console.Write(balance);
//     }
//     public virtual void Withdraw(int amount)
//     {
//         balance -= amount;
//         Console.WriteLine("Amount is withdrawn");
//     }
// }
// class SavingAccount : BankAccount
// {
//     private double rate = 0.05;
//     public override void Deposit(int amount)
//     {
//         balance += amount + (amount * rate);
//         Console.WriteLine($"Deposited with interest: {amount * rate} and {balance}");
//     }
// }
class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}
class Rectangle : Shape
{
    double L;
    double B;
    public Rectangle(double l, double b)
    {
        L = l;
        B = b;
    }
    public override double CalculateArea()
    {
        return L * B;
    }
}
class Circle : Shape
{
    double R;
    public Circle(double r)
    {
        R = r;
    }
    public override double CalculateArea()
    {
        return Math.PI * R * R;
    }
}
class Program
{
    static void Main()
    {
        // int n = int.Parse(Console.ReadLine());
        // int sum = 0;
        // for(int i =0; i <= n; i++)
        // {
        //     sum += i;
        // }
        // Console.WriteLine(sum);
        //===============================================
        // int[] arr1 = {1, 3, 4, 5};
        // int[] arr2 = {2, 6, 8, 9};
        // int[] final = new int[arr1.Length + arr2.Length];
        // int i = 0, j = 0, k= 0;
        // while(i < arr1.Length && j < arr2.Length)
        // {
        //     if(arr1[i] < arr2[j])
        //     {
        //         final[k++] = arr1[i++];
        //     }
        //     else
        //     {
        //         final[k++] = arr2[j++];
        //     }
        // }
        // while(i<arr1.Length)
        // {
        //     final[k++] = arr1[i++];
        // }
        // while(j<arr2.Length)
        // {
        //     final[k++] = arr2[j++];
        // }
        // foreach(int n in final)
        // {
        //     Console.Write(n + " ");   
        // }
        //=================================================
        // Person p = new Student();
        // p.GetDetails();
        // Employee e = new Manager();
        // Console.WriteLine($"Salary: {e.CalculateSalary()}");
        // Vehicle v = new Car();
        // v.StartEngine();
        // Vehicle m = new Motorcycle();
        // m.StartEngine();
        // SavingAccount s = new SavingAccount();
        // s.Deposit(1000);
        Shape s =  new Rectangle(5, 6);
        Console.WriteLine(s.CalculateArea());
        Shape c = new Circle(4);
        Console.WriteLine(c.CalculateArea());
    }
}   