using System;
using System.Collections.Generic;
public class Ascciiii
    {
        public static string Clean()
    {
        Console.WriteLine("Enter the word");
        string word = Console.ReadLine();
        if (string.IsNullOrEmpty(word) || word.Length < 6)
        {
            return "";
        }
        foreach (char c in word)
        {
            if (!char.IsLetter(c))
            {
                return "";
            }
        }
        word = word.ToLower();
        string cleanword = "";
        foreach (char i in word)
        {
            if (i % 2 != 0)
            {
                cleanword += i;
            }
        }
        if (cleanword.Length == 0)
        {
            return "";
        }
        char[] arr = cleanword.ToCharArray();
        Array.Reverse(arr);
        for (int a = 0; a < arr.Length; a++)
        {
            if(a % 2 == 0)
            {
                arr[a] = char.ToUpper(arr[a]);
            }
        }
        return new string(arr);
    }
    }
