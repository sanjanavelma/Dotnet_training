using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Payment
{
    public virtual void ProcessPayment()
    {
        Console.WriteLine("Payment is Processed");
    }
}
public class CreditCardPayment : Payment
{
    public override void ProcessPayment()
    {
        Console.WriteLine("Credit card Payment is Processed");
    }
}
