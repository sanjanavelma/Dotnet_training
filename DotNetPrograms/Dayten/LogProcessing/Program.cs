using System;
using LogProcessing;

class Program
{
    static void Main()
    {
        LogParser parser = new LogParser();

        Console.WriteLine("==== TASK 1: Validate Log Line ====");
        Console.WriteLine(parser.IsValidLine("[INF] Application started"));
        Console.WriteLine(parser.IsValidLine("[ERR] Database connection failed"));
        Console.WriteLine(parser.IsValidLine("INF Application started"));
        Console.WriteLine();


        Console.WriteLine("==== TASK 2: Split Log Line ====");
        string task2Input = "[INF] User login<***>Session created<====>Access granted";
        var splitResult = parser.SplitLogLine(task2Input);
        foreach (var part in splitResult)
            Console.WriteLine(part);
        Console.WriteLine();


        Console.WriteLine("==== TASK 3: Count Quoted Passwords ====");
        string task3Input =
        @"User said ""password123 is weak""
        Admin noted ""PASSWORD456 expired""
        No issue found";
        Console.WriteLine(parser.CountQuotedPasswords(task3Input));
        Console.WriteLine();


        Console.WriteLine("==== TASK 4: Remove End-of-Line Marker ====");
        string task4Input = "Transaction completed successfully end-of-line456";
        Console.WriteLine(parser.RemoveEndOfLineText(task4Input));
        Console.WriteLine();


        Console.WriteLine("==== TASK 5: Weak Password Detection ====");
        string[] lines =
        {
            "User entered password123 during login",
            "System startup completed",
            "Admin reset passwordABC",
            "Backup process finished"
        };

        var result = parser.ListLinesWithPasswords(lines);
        foreach (var r in result)
            Console.WriteLine(r);

        Console.WriteLine("\n==== PROGRAM COMPLETED ====");
    }
}
