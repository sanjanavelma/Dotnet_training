using System;
using System.Collections.Generic;
delegate void OrderDelegate(string orderId);
public class NotificationServices

    {
    public void SendEmail(string id)
    {
        Console.WriteLine("Emal sent for order " + id);
    }        
    public void SendSMS(string id)
    {
        Console.WriteLine("SMS sent for Order " + id);
    }
    }
