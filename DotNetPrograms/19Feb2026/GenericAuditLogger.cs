using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class AuditLogger<T>
{
    private readonly Queue<T> _events;
    private readonly int _threshold;
    private int _totalLogged;
    public AuditLogger(int threshold)

    {
        _events = new Queue<T>();
        _threshold = threshold;
        _totalLogged = 0;
    }
    public void LogEvent(T item)
    {
        _events.Enqueue(item);
        _totalLogged += 1;
        if(_events.Count == _threshold)
        {
            Flush();
        }
    }
    public List<T> Flush()
    {
        List<T> batch = new List<T>(_events);
        _events.Clear();
         return batch;
    }
    public int GetPendingCount()
    {
        return _events.Count();
    }
    public int GetTotalLoggedCount()
    {
        return _totalLogged;
    }
}


