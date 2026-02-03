using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
// class Program
// {
//     static void Main()
//     {
//         Trace.Listeners.Add(new ConsoleTraceListener());
//         Trace.WriteLine("Application exection started");
//         int a = 10;
//         int b = 0;
//         try
//             {
//                 int result = a / b;
//                 Console.WriteLine(result);
//             }
//         catch (Exception ex)
//             {
//                 Trace.WriteLine("Exception occured:" + ex.Message);
//             }
//             Trace.WriteLine("Application ended");
//     }
// }
//================================================================================
// class Program
// {
//     static void Main(string[] args)
//     {
//         int total = 0;
//         for (int i = 1; i <= 5; i++)
//         {
//             total += i; //breakpoint here
//         }
//         Console.WriteLine(total);
//         List<int> user = new List<int> {45, 55, 61, 70};
//         foreach(var age in user)
//         {
//             Console.WriteLine("Valid user age: " + age);
//         }
//         Queue<int> queue = new Queue<int>();
//         queue.Enqueue(1);
//         queue.Enqueue(2);
//         queue.Enqueue(3);
//         while (queue.Count > 0)
//         {
//             Console.WriteLine("Processing item: " + queue.Dequeue());
//         }
//     //     Trace.Listeners.Add(new ConsoleTraceListener());

//     //     Trace.WriteLine("Program started");

//     //     PerformCalculation(10, 5);
//     //     PerformCalculation(10, 0);   // Error case

//     //     Trace.WriteLine("Program ended");
//     // }

//     // static void PerformCalculation(int a, int b)
//     // {
//     //     Trace.WriteLine($"Entering Perform Calculation | a={a}, b={b}");

//     //     if (b == 0)
//     //     {
//     //         Trace.WriteLine("Error: Division by zero detected");
//     //         return;
//     //     }

//     //     int result = Divide(a, b);

//     //     Trace.WriteLine($"Calculation successful | Result={result}");
//     //     Trace.WriteLine("Exiting PerformCalculation");
//     // }

//     // static int Divide(int x, int y)
//     // {
//     //     Trace.WriteLine($"Dividing values | x={x}, y={y}");
//     //     return x / y;
//      }
// }
// class Student
// {
//     public string Name{get; set;}
//     public int Marks {get; set;}
// }
class Program
{
    //     class Employee
    // {
    //     public string Name {get; set;}
    //     public int Salary {get; set;}
    // }
    static void Main()
    {
        // List<Student> students = new List<Student>
        // {
        //     new Student {Name = "Rahul", Marks = 75},
        //     new Student {Name = "Meera", Marks = 55}
        // };
        // var result = students.Select(s => new
        // {
        //     s.Name,
        //     Grade = s.Marks > 60 ? "Pass" : "Fail"
        // }).ToList();
        // Console.WriteLine(result.GetType());
        // foreach (var r in result)
        // {
        //     Console.WriteLine($"Name: {r.Name}, Grade: {r.Grade}");
        // }
        //=======================================================================
        // List<Employee> employees = new List<Employee>
        // {
        //     new Employee {Name = "Amit", Salary = 50000},
        //     new Employee {Name = "Ravi", Salary = 70000},
        //     new Employee {Name = "Neha", Salary = 60000}
        // };
        // var sortBySalary = employees.OrderBy(e => e.Salary);
        // var sorteedBySalay = employees.OrderBy(e => e.Name);
        //==========================================================================
    List<int> numbers = new List<int> { 10, 20, 30 };
    int first = numbers.First();
    Console.WriteLine(first);
    int result = numbers.First(n => n > 15);
    Console.WriteLine(result);
    int last = numbers.Last();
    Console.WriteLine(last);
    int results = numbers.Last(n => n < 25);
    Console.WriteLine(results);
    List<int> numberss = new List<int> {3};
    int value = numberss.Single();
    Console.WriteLine(value);
    List<int> numbersss = new List<int> {1, 2, 3};
    int result3 = numbersss.Single(n => n == 2);
    Console.WriteLine(result3);

    }
}