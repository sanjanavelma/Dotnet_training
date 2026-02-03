using System;
using System.Collections;
using System.Collections.Generic;
public class lists
    {
        public static void ls()
    {
        List<int> nums = new List<int>();
        nums.Add(10);
        nums.Add(20);
        nums.Add(30);
        foreach (int x in nums)
        {
            Console.WriteLine(x);
        }
    }
    }
public class ArraysList
{
    public static void AL()
    {
        ArrayList list = new ArrayList();
        list.Add(10);        
        list.Add("Sanjana");   
        list.Add(3.14);          
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

    }
}
public class SortedLs
{
    public static void SL()
    {
        SortedList<string, string> l = new SortedList<string, string>();
        l.Add("a", "A");
        l.Add("b", "B");
        Console.WriteLine(l["b"]);
        foreach (var item in l)
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}
