using System;
using System.Collections.Generic;
public class Dicts
    {
        public static void DT()
    {
        Dictionary<int, string> DY = new Dictionary<int, string>();
        DY.Add(1, "Sanjana");
        DY.Add(2, "Sathvika");
        Console.WriteLine(DY[1]);
        foreach (KeyValuePair<int, string> d in DY)
        {
            Console.WriteLine(d.Key + " - " + d.Value);
        }
    }
    }
