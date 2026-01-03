using System;
using System.Text;
public class Equalss
{
    public static void CheckEquality()
    {
        StringBuilder sb1 = new StringBuilder("Test");
        StringBuilder sb2 = new StringBuilder("Test");
        Console.WriteLine(sb1.Equals(sb2));
        StringBuilder sb3 = sb1;
        Console.WriteLine(sb1.Equals(sb3));
        Console.WriteLine(object.ReferenceEquals(sb2, sb3));
        string str1 = "Hello";
        string str2 = "Hello";
        Console.WriteLine(str1 == str2);
        Console.WriteLine(str1.Equals(str2));
    }
}