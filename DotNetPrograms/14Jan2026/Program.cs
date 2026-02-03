using System;
//using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
public class Program
{
    // public static void Main()
    // {
    //     Thread worker = new Thread(DoWork);
    //     Parallel.For(0, 5, i =>
    //     {
    //         Console.WriteLine($"Processing item {i}");
    //     });
    //     worker.Start();
    //     Console.WriteLine("Main thread continues...");
    // }
    // static void DoWork()
    // {
    //     for (int i = 1; i <= 5; i++)
    //     {
    //         Thread.Sleep(5000);
    //         Console.WriteLine("Worker thread: " + i);
    //     }
    // }
    // static void Main()
    // {
    //     // int [] numbers = new int[10];
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = i + 1;
        // }
        // int sum = 0;
        // Parallel.For(0, numbers.Length, i =>
        // {
        //     sum += numbers[i]; //Not thread-safe (for demonsttration)
        // });
        // Console.WriteLine("Sum: " + sum);
        // Parallel.For(0, numbers.Length, () => 0, (i, loopState, localSum) =>
        // {
        //     return localSum + numbers[i];
        // },
        // localSum =>
        // {
        //     Interlocked.Add(ref sum, localSum);
        // });
        // Console.WriteLine("Sum: " + sum);}
    // static async Task Main(string[] args)
    // {
    //     int result = await GetDataAsync();
    //     Console.WriteLine(result);
    // }

    // static async Task<int> GetDataAsync()
    // {
    //     await Task.Delay(1000);
    //     return 42;
    // }
    static async Task Main()
    {
        Console.WriteLine("Start reading file....");
        string content = await File.ReadAllTextAsync("data.txt");
        Console.WriteLine("File content: ");
        Console.WriteLine(content);
        Console.WriteLine("End of program");
    }
    }

