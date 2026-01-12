using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        Trace.Listeners.Add(new ConsoleTraceListener());
        Trace.WriteLine("Application exection started");
        int a = 10;
        int b = 0;
        try
            {
                int result = a / b;
                Console.WriteLine(result);
            }
        catch (Exception ex)
            {
                Trace.WriteLine("Exception occured:" + ex.Message);
            }
            Trace.WriteLine("Application ended");
    }
}
