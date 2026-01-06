using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class LogEntry
    {
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }

        public LogEntry(string message)
        {
            Message = message;
            CreatedAt = DateTime.Now;
        }
    }
        public class LogCache
    {
        private List<LogEntry> _cache = new List<LogEntry>();

        public void Add(LogEntry entry)
        {
            _cache.Add(entry);
        }

        public void Clear()
        {
            _cache.Clear();
        }
    }
     public class FileLogger : IDisposable
    {
        private StreamWriter _writer;
        private bool disposed = false;

        public FileLogger(string filePath)
        {
            _writer = new StreamWriter(filePath, append: true);
            Console.WriteLine("File resource acquired.");
        }

        public void WriteLog(string message)
        {
            _writer.WriteLine($"{DateTime.Now}: {message}");
            _writer.Flush();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            Console.WriteLine("FileLogger disposed.");
        }        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
                _writer?.Dispose();
                Console.WriteLine("Managed resources released.");
            }
            Console.WriteLine("Unmanaged resources released.");
            disposed = true;
        }
        ~FileLogger()
        {
            Dispose(false);
        }
    }
    public class LogProcessor
    {
        private LogCache _cache;
        private WeakReference<LogCache>? _weakCacheRef;

        public void ProcessLogs()
        {
            Console.WriteLine("\n--- Log Processing Started ---");

            long memoryBefore = GC.GetTotalMemory(false);
            Console.WriteLine($"Initial Memory: {memoryBefore} bytes");

            _cache = new LogCache();
            _weakCacheRef = new WeakReference<LogCache>(_cache);

            for (int i = 0; i < 10000; i++)
            {
                _cache.Add(new LogEntry($"Log {i}"));
            }
            long memoryAfterCreation = GC.GetTotalMemory(false);
            Console.WriteLine($"Memory After Log Creation: {memoryAfterCreation} bytes");
            _cache.Clear();
            _cache = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            long memoryAfterGC = GC.GetTotalMemory(false);
            Console.WriteLine($"Memory After GC: {memoryAfterGC} bytes");
            bool isAlive = _weakCacheRef.TryGetTarget(out _);
            Console.WriteLine($"Is Cache Alive (WeakReference): {isAlive}");
        }
    }

