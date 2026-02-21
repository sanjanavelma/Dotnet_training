using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Helloworld
{
    public static void StringManipulation(string str)
    {
        Console.WriteLine(str.ToUpper().Trim());
        string v = "AEIOUaeiou";
        int l = 0;
        foreach(char c in str)
        {
            if(v.Contains(c))
            {
                l++;
            }
        }
        Console.WriteLine("Vowel Count: " + l);
        Console.WriteLine(str.Trim().ToUpper().Replace(" ", "-"));
        string[] strs = str.Split(" ");
        string sfinal = "";
        foreach(string s in strs)
        {
            if(s.Length > sfinal.Length)
            {
                sfinal = s;
            }
        }
        Console.WriteLine("Longest Word: " + sfinal);
    }
}
