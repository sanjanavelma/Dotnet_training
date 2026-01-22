using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public delegate void cal(int a, int b);
public delegate void Len(string text);
public class Calculator
{
    public static void Adds(int x, int y)
    {
        Console.WriteLine(x + y);
    }
    public static void Subtracts(int x, int y)
    {
        Console.WriteLine(x - y);
    }

    public static void FindLength(string value)
    {
        Console.WriteLine(value.Length);
    }
}

