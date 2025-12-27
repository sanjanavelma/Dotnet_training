using System;
class Program
{
    public static void Main()
    {

        int Choice = 0;
        do
        {
            Console.WriteLine("==========MediSure Clinic Billing==========");
            Console.WriteLine("1. Create New Bill(Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Choose you option: ");
            try
            {
                Choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid Option, Please enter a valid number..");
                Choice = 0;
            }
            switch(Choice)
            {
                case 1:
                    MediSureClinic.CreateBill();
                    break;
                case 2:
                    MediSureClinic.ViewBill();
                    break;
                case 3:
                    MediSureClinic.ClearBill();
                    break;
                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }while (Choice != 4);
    }
}