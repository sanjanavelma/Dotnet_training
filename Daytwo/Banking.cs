using System;

class Bank
{
    static int balance = 1000000;

    public static void Banking()
    {
        int val;
        do{
        Console.WriteLine("1. Check Loan Eligibility\n2. Calculate Tax\n3. Enter Transactions\n4. Exit");
        Console.WriteLine("Enter Your Choice(1/2/3/4)..:");
        val = Convert.ToInt32(Console.ReadLine());

        switch (val)
        {
            case 1:
                Check();
                break;
            case 2:
                Tax();
                break;
            case 3:
                Transaction();
                break;
            case 4:
                Console.WriteLine("Thank you!");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
        }while (val != 4);
    }

    static void Check()
    {
        Console.WriteLine("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Monthly Income: ");
        int income = Convert.ToInt32(Console.ReadLine());

        if (age >= 21 && income >= 30000)
        {
            Console.WriteLine("Eligible For Loan...!");
        }
        else
        {
            Console.WriteLine("Not Eligible For Loan");
        }

    }

    static void Tax()
    {
        Console.WriteLine("Enter Annual Income: ");
        int annual = Convert.ToInt32(Console.ReadLine());

        if (annual <= 250000)
        {
            Console.WriteLine("You will get 0% Tax");
        }
        else if (annual <= 500000)
        {
            Console.WriteLine("You will get 5% Tax");
        }
        else if (annual <= 1000000)
        {
            Console.WriteLine("You will get 20% Tax");
        }
        else
        {
            Console.WriteLine("You will get 30% Tax");
        }
    }

    static void Transaction()
    {
        Console.WriteLine("Withdraw(1)/Add(2)/Balance(3)..: ");
        int value = Convert.ToInt32(Console.ReadLine());

        switch (value)
        {
            case 1:
                Withdraw();
                break;

            case 2:
                Add();
                break;

            case 3:
                ShowBalance();
                break;

            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }

    static void Withdraw()
    {
        Console.WriteLine("Enter the amount to withdraw: ");
        int amount = Convert.ToInt32(Console.ReadLine());

        if (amount > balance)
            Console.WriteLine("Invalid, insufficient balance");
        else
        {
            balance -= amount;
            Console.WriteLine("Withdraw Successful!");
        }
    }

    static void Add()
    {
        Console.WriteLine("Enter the amount to add...");
        int amount2 = Convert.ToInt32(Console.ReadLine());
        balance += amount2;
        Console.WriteLine("Amount Added!");
    }

    static void ShowBalance()
    {
        Console.WriteLine($"Balance: {balance}");
    }
}
