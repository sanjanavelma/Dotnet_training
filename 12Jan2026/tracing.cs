using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
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
