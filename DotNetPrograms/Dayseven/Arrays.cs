using System;
using System.Collections.Generic;
public class Arrays
    {
        // int [] numbers;
        // int[] nums = new int[5];
        int[] nums2 = {10, 20, 30, 40, 50};
        public void Display()
    {
        Array.Clear(nums2, 1, nums2.Length);
        foreach (int x in nums2)
        {
            Console.WriteLine(x);
        }

    }
    }
public class Matrixs
{
    int[,] matrix =
    {
        {1,2,3},
        {4,5,6}
    };
    public void Display()
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
    {
            for (int j = 0; j < matrix.GetLength(1); j ++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
    }
    }

}
public class Copyy
{
    public static void copies()
    {
        int[] src = {1, 2, 3};
        int[] dest = new int[3];
        Array.Copy(src, dest, 3);
        int[] dest1 = new int[3];
        Array.Copy(src, dest1, 1);
        foreach (int x in src)
        {
            Console.Write(x);
        }
        Console.WriteLine();
        foreach (int c in dest1)
        {
            Console.Write(c);
        }
    }
}
public class Resixe
{
    public static void Rs()
    {
        int[] nums = {1, 2};
        Array.Resize(ref nums, 4);
        // Array.Resize(nums, 4);
        Array.Resize(ref nums, 1);
        Console.WriteLine(nums.Length);
    }
}

public class Copy
{
    public static void Cp()
    {
        int[] src ={7,8,9};
        int[] src1={7,8,9};
        int[] dest = new int[3];
        // Copy all elements
        Array.Copy(src, dest, 3);
        Console.WriteLine("After copying 3 elements:");
        foreach (int n in dest)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        // Copy only first 2 elements
        int[] dest2 = new int[3];
        Array.Copy(src, dest2, 2);
        Console.WriteLine("After copying 2 elements:");
        foreach (int n in dest2)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        Array.Resize(ref src,5);
        Console.WriteLine("After Resizing elements to 5:");
            foreach (int n in src)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        // Array.Resize(src,5); // without ref: Argument 1 must be passed with the 'ref' keyword
        Array.Resize(ref src1,1);
        Console.WriteLine("After Resizing elements to 1:");
             foreach (int n in src1)
        {
            Console.Write(n + " ");
        }
      
    }
}
public class Exist
{
    public static void Ex()
    {
        int[] nums = { 5, 10, 15, 20 };
        bool result = Array.Exists(nums, x => x == 15);
        Console.WriteLine(result); 
    }
}