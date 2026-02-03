using System;

namespace Saturday_Assessments.HealthSyncBiling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. In-House Consultant");
            Console.WriteLine("2. Visiting Consultant");
            Console.Write("Choose consultant type: ");

            int choice = int.Parse(Console.ReadLine());
            Consultant consultant = (choice == 1) ? new InHouse() : new Visiting();

            Console.Write("Enter Consultant ID: ");
            consultant.Id = Console.ReadLine();

            if (!consultant.ValidateConsultantId())
            {
                Console.WriteLine("Invalid doctor id");
                return;
            }

            Console.Write("Enter Name: ");
            consultant.Name = Console.ReadLine();

            if (consultant is InHouse ih)
            {
                Console.Write("Enter Monthly Stipend: ");
                ih.MonthlyStipend = double.Parse(Console.ReadLine());
            }
            else if (consultant is Visiting v)
            {
                Console.Write("Enter Consultations Count: ");
                v.ConsultationsCount = int.Parse(Console.ReadLine());
                Console.Write("Enter Rate per Visit: ");
                v.RatePerVisit = int.Parse(Console.ReadLine());
            }

            consultant.CalculateGrossPayout();
            double gross = consultant.PayoutAmount;

            consultant.ApplyTax();

            Console.WriteLine("\n--- Billing Summary ---");
            Console.WriteLine($"Gross Payout: {gross}");
            Console.WriteLine($"Net Payout: {consultant.PayoutAmount}");
        }
    }
}
