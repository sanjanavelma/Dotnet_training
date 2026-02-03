using System;
using System.Collections.Generic;
public class twosorted
    {
        public static void TS()
    {
        int[] arr1 = {1, 3, 5};
        int[] arr2 = {2, 4, 6};
        int n1 = arr1.Length;
        int n2 = arr2.Length;
        int[] merged = new int[n1 + n2];
        int i = 0, j = 0, k = 0;
        while (i < n1 && j < n2)
        {
            if (arr1[i] < arr2[j])
                merged[k++] = arr1[i++];
            else
                merged[k++] = arr2[j++];
        }
        while (i < n1)
            merged[k++] = arr1[i++];
        while (j < n2)
            merged[k++] = arr2[j++];
        Console.WriteLine("Merged Sorted Array:");
        foreach (int x in merged)
            Console.WriteLine(x);
    }
}
    