using System;
using System.Collections;
using System.Linq;
class Program
{
    static void Main()
    {
        BankSystem bank = new BankSystem();

        bank.Accounts.Add(new SavingsAccount("101", "Ravi", 60000));
        bank.Accounts.Add(new CurrentAccount("102", "Rohan", 45000));
        bank.Accounts.Add(new LoanAccount("103", "Anita", 80000));

        while (true)
        {
            Console.WriteLine("\n1.Deposit 2.Withdraw 3.Transfer 4.Reports 5.Exit");
            int ch = int.Parse(Console.ReadLine());

            try
            {
                if (ch == 1)
                {
                    bank.Accounts[0].Deposit(5000);
                }
                else if (ch == 2)
                {
                    bank.Accounts[0].Withdraw(2000);
                }
                else if (ch == 3)
                {
                    bank.Transfer(bank.Accounts[0], bank.Accounts[1], 1000);
                }
                else if (ch == 4)
                {
                    bank.RunReports();
                }
                else break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
