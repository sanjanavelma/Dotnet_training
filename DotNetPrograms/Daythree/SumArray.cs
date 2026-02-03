using System;
public class SumArray
    {
      public static int SA(params int[] arr)
    {
        int res = 0;
        foreach(int i in arr)
        {
            res += i;
        }
        return res;
    }  
    }
