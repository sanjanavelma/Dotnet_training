using System;
namespace Saturday_Assessments.BankingTransaction
{
    public class Program
    {
        public static void Main()
        {
            Account UA = new Account();
            int choice = 0;
            Console.WriteLine("Enter the account number");
            UA.AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter the balance");
            UA.Balance = decimal.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter the Choice");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid Input. Please enter a  Number(1/2/3): ");
                    choice = 0;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the amount to deposit");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            decimal currentBalance = UA.Deposit(depositAmount);
                            Console.WriteLine("Balance amount: " + currentBalance);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter the amount to withdraw");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                        {
                            decimal currentBalance = UA.Withdraw(withdrawAmount);
                            Console.WriteLine("Balance amount: " + currentBalance);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Thank you for using Banking Transaction App.");
                        break;

                    default:
                        Console.WriteLine("Invalid menu option.");
                        break;
                }
            }while (choice != 3);
        }
    }
}            
            