using System;
class Banking
{
    public static void FinanceBankingSystem()
{
        int val;
        do{
        Console.WriteLine("1. Debit\n2. Credit \n3. Exit");
        Console.WriteLine("Enter Your Choice(1/2/3)..:");
        val = Convert.ToInt32(Console.ReadLine());

        switch (val)
        {
            case 1:
                Debit();
                break;
            case 2:
                Credit();
                break;
            case 3:
                Console.WriteLine("Thank you!");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
        }while (val != 4);
    }
}

