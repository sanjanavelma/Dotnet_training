using System;
using System.Collections.Generic;
public class Freq
    {
        public static void fe()
    {
        int[] arr = {1, 2, 3, 2, 1, 4, 2};
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int n in arr)
        {
            if (freq.ContainsKey(n))
            {
                freq[n]++;
            }
            else
            {
                freq[n] = 1;
            }
        }
        foreach (var i in freq)
        {
            Console.WriteLine(i.Key +" -> " + i.Value);
        }
    }
    }
