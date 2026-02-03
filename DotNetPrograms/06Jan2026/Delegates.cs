using System;
delegate void PaymentDelegate(decimal amount);
public class PaymentService
    {
        public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Payment of " + amount + " Processed successfully");
    }
        
    }
static class PaymentExtensions
{
    public static bool IsValidPayment(this decimal amount)
    {
        return amount > 0 && amount <= 1_000_000;
    }
}
