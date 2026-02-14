using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
class Program
{
    static void Main()
    {
        // List<int> numbers = new List<int>{10, 20, 30};
        // var deferredQuery = numbers.Where(n => n > 15);
        // numbers.Add(40);
        // Console.WriteLine("Deferred Execution Result: ");
        // foreach(var n in deferredQuery)
        // {
        //     Console.WriteLine(n);
        // }
        // Console.WriteLine("Immediate Execution:");
        // var ime=numbers.Where(n=>n>15).ToList();
        // numbers.Add(50);
        // foreach (var i in ime)
        // {
        //     Console.WriteLine(i);
        // }
        // List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6 };

        // int half = nums.Count / 2;

        // var firstHalf = nums.Take(half).ToList();
        // var secondHalf = nums.Skip(half).ToList();

        // Console.WriteLine("First Half: " + string.Join(", ", firstHalf));
        // Console.WriteLine("Second Half: " + string.Join(", ", secondHalf));
        ArrayList arr = new ArrayList() { 1, "Mari", "MCA", 2000 };
        IEnumerable<int> i = arr.OfType<int>();  
        Console.WriteLine(string.Join(", ", i));
        string[] names = { "Ashi", "MariMuthu", "Sanjana", "Priya", "Aryan", "Arjun" };
        IEnumerable<string> s=names.Where(n=>n.StartsWith("A"));
        Console.WriteLine(string.Join(", ", s));
        IEnumerable<string> e=names.Where(n=>n.EndsWith("u")).Select(n=>"Mr. "+ n);
        Console.WriteLine(string.Join(", ",e));
        //=================================================================================================
        Console.WriteLine();
        int[] number={1,2,3,4,5,6,2,7,8,9};
        IEnumerable<int> result = number.SkipWhile(n=>n<5);
        foreach (int n in result){
            Console.WriteLine(n);
        }
        Console.WriteLine();
        IEnumerable<int> result1 = number.TakeWhile(n=>n<5);
        foreach (int n in result1){
            Console.WriteLine(n);
        }
        //==================================================================================================
        
    }
}
