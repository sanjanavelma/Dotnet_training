using System;
using System.Collections;
using System.Collections.Generic;
public class Hastsets
    {
        public static void hss()
    {
        HashSet<int> HS = new HashSet<int>();
        HS.Add(1);
        HS.Add(2);
        foreach (int x in HS)
        {
            Console.WriteLine(x);
        }
    }

    }
