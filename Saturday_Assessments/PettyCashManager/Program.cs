using System;

class Program
{
    static void Main()
    {
        Voucher voucher = new Voucher();

        while (true)
        {
            Console.WriteLine("\n=== Voucher & Expense Report System ===");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View All Expenses");
            Console.WriteLine("3. Generate Expense Report");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        AddExpense(voucher);
                        break;

                    case "2":
                        ViewAllExpenses(voucher);
                        break;

                    case "3":
                        GenerateReport(voucher);
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static void AddExpense(Voucher voucher)
    {
        Console.Write("Expense Name (Tea/Coffee/Travel/etc): ");
        string name = Console.ReadLine();

        Console.Write("Cost: ");
        int cost = int.Parse(Console.ReadLine());

        voucher.AddExpense(name, cost);

        Console.WriteLine("Expense added successfully");
    }

    static void ViewAllExpenses(Voucher voucher)
    {
        var list = voucher.GetAllExpenses();

        if (list.Count == 0)
        {
            Console.WriteLine("No expenses added yet");
            return;
        }

        Console.WriteLine("\n--- All Expenses ---");
        foreach (var e in list)
        {
            Console.WriteLine(e.Name + " - " + e.Cost + " - " + e.Date);
        }
    }

    static void GenerateReport(Voucher voucher)
    {
        Console.Write("Enter Expense Name for Report: ");
        string name = Console.ReadLine();

        Report.GenerateExpenseReport(voucher, name);
    }
}
