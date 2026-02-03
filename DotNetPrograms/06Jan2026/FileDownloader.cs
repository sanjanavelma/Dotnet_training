using System;
using System.Threading;
public delegate void DownloadFinishedHandler(string fileName);
class FileDownloader
{
    // STEP 2: Method that accepts the callback
    public void DownloadFile(string name, DownloadFinishedHandler callback)
    {
        Console.WriteLine($"Starting download: {name}...");
        // Simulating work
        Thread.Sleep(2000); 
        Console.WriteLine($"{name} download complete.");
        // STEP 3: Execute the Callback
        if (callback != null)
        {
            callback(name); 
        }
    }
}
