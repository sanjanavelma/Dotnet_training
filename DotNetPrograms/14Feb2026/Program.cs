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

using System;
class Program
{
    static void Main()
    {
        string input = "Sanjana";
        
    }
}