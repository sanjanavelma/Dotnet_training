using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> products = new List<string>
        {
            "Pen","Book","Pen","Pencil","Book"
        };

        List<string> duplicates = FindDuplicates(products);

        foreach (var item in duplicates)
        {
            Console.WriteLine(item);
        }
    }

    public static List<string> FindDuplicates(List<string> products)
    {
        return products
                .GroupBy(p => p)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();
    }
}