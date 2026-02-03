using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saturday_Assessments.GYMStream
{
    public class Program
    {
        static void Main()
        {
            MemberShip mem = new MemberShip();
            try
            {
                Console.WriteLine("--GymStream Enrollment Portal--");
                Console.WriteLine("Enter membership tier (Basic/Premium/Elite):");
                mem.Tier = Console.ReadLine();

                Console.WriteLine("Enter duration in months:");
                mem.DurationInMonths = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter base price per month:");
                mem.BasePriceperMonth = Convert.ToDouble(Console.ReadLine());
                if (mem.ValidateEnrollment())
                {
                    Console.WriteLine("\nEnrollment Successful!");
                    double finalBill = mem.CalculateTotalBill();
                    Console.WriteLine($"Total amount after discount: {finalBill:F2}");
                }
            }
            catch (InvalidTierException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}