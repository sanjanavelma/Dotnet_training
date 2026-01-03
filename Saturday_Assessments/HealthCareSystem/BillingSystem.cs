public class Billing
{
    public double ConsultationFee { get; set; }
    public double TestCharges { get; set; }
    public double RoomCharges { get; set; }
    public double Discount { get; set; }
    public double TaxPercent { get; set; }
    public double Total()
    {
        double baseAmount = ConsultationFee + TestCharges + RoomCharges;
        double discountAmount = baseAmount * (Discount / 100);
        double afterDiscount = baseAmount - discountAmount;
        double taxAmount = afterDiscount * (TaxPercent / 100);
        return afterDiscount + taxAmount;
    }
    public void PrintBill()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("            HOSPITAL BILL");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Consultation Fee: " + ConsultationFee);
        Console.WriteLine("Test Charges: " + TestCharges);
        Console.WriteLine("Room Charges: " + RoomCharges);
        Console.WriteLine("Discount (%): " + Discount);
        Console.WriteLine("Tax (%): " + TaxPercent);
        Console.WriteLine("Total Payable: " + Total());
        Console.WriteLine("---------------------------------");
    }
}
