using System;
public class PatientBill
{
    public string BillId{get; set;}
    public string PatientName{get; set;}
    public bool HasInsurance{get; set;}
    public decimal ConsultationFee{get; set;}
    public decimal LabCharges{get; set;}
    public decimal MedicineCharges{get; set;}
    public decimal GrossAmount{get; set;}
    public decimal DiscountAmount{get; set;}
    public decimal FinalPayable{get; set;}
}

public class MediSureClinic
{
    public static PatientBill LastBill = null;
    public static bool HasLastBill = false;
    public static void CreateBill()
    {
        Console.WriteLine("Enter the Bill ID: ");
        string billId = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(billId))
        {
            Console.WriteLine("Bill Id connot be empty");
            return;
        }
        Console.WriteLine("Enter the Patient Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Do Patient have Insurance(Y/N): ");
        string inss = Console.ReadLine();
        bool insure = (inss == "Y" || inss == "y");
        Console.WriteLine("Enter the ConsulationFee(>0): ");
        decimal consolefee = Convert.ToDecimal(Console.ReadLine());
        if (consolefee <= 0)
        {
            Console.WriteLine("Consulation fee can't be less than zero.");
            return;
        }
        Console.WriteLine("Enter Lab Charges(>= 0): ");
        decimal LbCharge = Convert.ToDecimal(Console.ReadLine());

        if (LbCharge < 0)
        {
            Console.WriteLine("Lab Fee Can't be Negative.");
            return;
        }
        Console.WriteLine("Enter Medicine Charges..");
        decimal Medfee = Convert.ToDecimal(Console.ReadLine());
        if (Medfee < 0)
        {
            Console.WriteLine("Medicine fee can't be Negative.");
            return;
        }
        PatientBill bill = new PatientBill();
        bill.BillId = billId;
        bill.PatientName = name;
        bill.HasInsurance = insure;
        bill.ConsultationFee = consolefee;
        bill.LabCharges = LbCharge;
        bill.MedicineCharges = Medfee;
        bill.GrossAmount = consolefee + LbCharge + Medfee;
        if(insure)
        {
            bill.DiscountAmount = bill.GrossAmount * 0.10m;
        }
        else
        {
            bill.DiscountAmount = 0;
        }
        bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;
        LastBill = bill;
        HasLastBill = true;
        Console.WriteLine("Bill created successfully");
        Console.WriteLine("Gross Amount: " + bill.GrossAmount.ToString("0.00"));
        Console.WriteLine("Discount Amount: " + bill.DiscountAmount.ToString("0.00"));
        Console.WriteLine("Final Payable: " + bill.FinalPayable.ToString("0.00"));
    }
    public static void ViewBill()
    {
        if(!HasLastBill || LastBill == null)
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
            return;
        }
        Console.WriteLine("---------Last Bill----------");
        Console.WriteLine("BillId: " + LastBill.BillId);
        Console.WriteLine("Patient: " + LastBill.PatientName);
        Console.WriteLine("Insured: " + (LastBill.HasInsurance ? "Yes" : "No"));
        Console.WriteLine("Consultation fee: " + LastBill.ConsultationFee.ToString("0.00"));
        Console.WriteLine("Lab Charges: " + LastBill.LabCharges.ToString("0.00"));
        Console.WriteLine("Medicine Charge: " + LastBill.MedicineCharges.ToString("0.00"));
        Console.WriteLine("Gross Amount: " + LastBill.GrossAmount.ToString("0.00"));
        Console.WriteLine("Discount Amount: " + LastBill.DiscountAmount.ToString("0.00"));
        Console.WriteLine("Final Pay: " + LastBill.FinalPayable.ToString("0.00"));
        Console.WriteLine("-------------------------------------------------------");
        
    }
    public static void ClearBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared");
    }
}
