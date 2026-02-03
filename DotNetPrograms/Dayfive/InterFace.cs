using System;
interface IPrintable
{
    void Print();
    //void Scan();
    static int c = 0;
}

class Report : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing report");
    }
}
interface ILogger
{
    void Log();
}
interface INotifier
{
    void Log();
}
class FileLogger : ILogger, INotifier
{
    void ILogger.Log()
    {
        Console.WriteLine("Logging to file via ILogger");
    }
    void INotifier.Log()
    {
        Console.WriteLine("Logging to notification via INotifier");
    }
}
class ResourceHandler : IDisposable, INotifier
{
    void IDisposable.Dispose()
    {
        Console.WriteLine("Resource disposed");
    }
    void INotifier.Log()
    {
        Console.WriteLine("Notification sent");
    }
}
