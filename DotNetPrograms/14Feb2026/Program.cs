// using System;
// class Program{
//     static void Main()
//     {
//         string input1="Hello 2";
//         string[] input2 = input1.Split(" ");
//         string str = input2[0];
//         int gap = Convert.ToInt32(input2[1]);
//         char[] arr = str.ToCharArray();
//         Array.Reverse(arr);
//         string res = new string(arr).ToLower();
//         string result = res.Substring(gap) + res.Substring(0, gap);
//         Console.WriteLine(result);
//         //expected output eholl
//         //reverse the string and then move it by k chracters
//     }
// }
// using System;
// using Microsoft.Win32;

// class Program
// {
//     static void Main()
//     {
//         string keyPath = @"Software\MyTestApp";

//         // Create or open key
//         using (RegistryKey key = Registry.CurrentUser.CreateSubKey(keyPath))
//         {
//             if (key == null)
//             {
//                 Console.WriteLine("Failed to create or open registry key.");
//                 return;
//             }

//             // Write value
//             key.SetValue("Username", "Student125");
//             Console.WriteLine("Value written.");

//             // Read value safely
//             object value = key.GetValue("Username");
//             if (value != null)
//             {
//                 Console.WriteLine("Read from registry: " + value.ToString());
//             }
//         }

//         // Delete safely
//         using (RegistryKey deleteKey = Registry.CurrentUser.OpenSubKey(keyPath, true))
//         {
//             if (deleteKey != null && deleteKey.GetValue("Username") != null)
//             {
//                 deleteKey.DeleteValue("Username");
//                 Console.WriteLine("Value deleted.");
//             }
//         }
//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         string input = "Sanjana";
//         char[] rev = new char[input.Length];
//         for(int i = 0; i<input.Length; i++)
//         {
//             rev[i] = input[input.Length - 1 - i];
//         } 
//         Console.WriteLine(new string(rev));
//     }
// }

// using System;
// using System.Linq;
// class Program
// {
//     static void Main()
//     {
//         int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
//         int Max = arr[0];
//         foreach(int n in arr)
//         {
//             if(Max < n)
//             {
//                 Max = n;
//             }
//         }
//         Console.WriteLine(Max);
//     }
// }

// using System;
// using System.Collections;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         List<int> nums = new List<int>{1, 2, 3, 4, 4, 5};
//         HashSet<int> unique = new HashSet<int>(nums);
//         foreach(int n in unique)
//         {
//             Console.WriteLine(n);
//         }
//         Console.WriteLine(string.Join(",", unique));
//     }
// }

using System;
using System.Collections;
using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         int[] arr = {1, 2, 3, 4, 5, 5, 4};
//         Dictionary<int, int> freq = new Dictionary<int, int>();
//         foreach(int n in arr)
//         {
//             if(freq.ContainsKey(n))
//             {
//                 freq[n]++;
//             }
//             else
//             {
//                 freq[n] = 1;
//             }
//         }
//         foreach(var v in freq)
//         {
//             Console.WriteLine($"{v.Key}: {v.Value}");
//         }
//     }
// }

class Program
{
    static void Main()
    {
        string input = "gegeg";
        char[] arr = input.ToCharArray();
        arr = arr.Reverse().ToArray();
        string final = new string(arr);
        if (input == final)
        {
            Console.WriteLine(input + " is Palindrom");
        }
        else
        {
            Console.WriteLine("Not Palindrom");
        }
    }
}

