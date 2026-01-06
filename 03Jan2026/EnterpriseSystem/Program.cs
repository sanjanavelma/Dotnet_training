using System;
class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Enterprise Log Processing System ===");
            using (FileLogger logger = new FileLogger("app.log"))
            {
                logger.WriteLog("Application Started");
            }
            LogProcessor processor = new LogProcessor();
            processor.ProcessLogs();
            object obj = new object();
            Console.WriteLine($"Generation of new object: {GC.GetGeneration(obj)}");
            Console.WriteLine("Application execution completed.");
        }
    }

