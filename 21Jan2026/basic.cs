using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class basic
    {
        public static List<int> divibyTwo = new List<int>();
        public static List<int> divibyThree = new List<int>();
        public static List<int> divibyNone = new List<int>();
        public static void DivByTwo()
    {
        for(int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                divibyTwo.Add(i);
            }
        }
        Console.WriteLine("\nDivisible by Two");
        foreach(int i in divibyTwo)
        {
            Console.Write(" " + i);
        }
    }
    public static void DivByThree()
    {
        for (int j = 0; j <= 100; j++)
        {
            if (j % 3 == 0)
            {
                divibyThree.Add(j);
            }
        }
        Console.WriteLine("\nDivisible by Three");
        foreach(int j in divibyThree)
        {
            Console.Write(" " +j);
        }
    }
    public static void DivByNone()
    {
        for (int k = 0; k <= 100; k++)
        {
            if (k % 2 != 0 && k % 3 != 0)
            {
                divibyNone.Add(k);
            }
        }
        Console.WriteLine("\nDivisble by None: ");
        foreach(int k in divibyNone)
        {
            Console.Write(" " +k);
        }
    }
    }
