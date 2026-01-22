using System;
using System.Collections;
public class ExpenseItem
{
    public string Name{get;}
    public int Cost{get;}
    public string Date {get;}
    public ExpenseItem(string name, int cost, string date)
    {
        if (cost <= 0)
        {
            throw new Exception("Cost must be greater than zero");
        }
        Name = name;
        Cost = cost;
        Date = date;
    }
}
public class Voucher
{
    private List<ExpenseItem> expenses;
    public Voucher()
    {
        expenses = new List<ExpenseItem>();
    }
    public void AddExpense(string name, int cost)
    {
        string date = DateTime.Now.ToShortDateString();
        ExpenseItem item = new ExpenseItem(name, cost, date);
        expenses.Add(item);
    }
    public List<ExpenseItem> GetAllExpenses()
    {
        return expenses;
    }
    public List<ExpenseItem> GetExpensesByName(string name)
    {
        List<ExpenseItem> result = new List<ExpenseItem>();
        foreach (ExpenseItem e in expenses)
        {
            if (e.Name.ToLower() == name.ToLower())
            {
                result.Add(e);
            }
        }
        return result;
    }
}
public class Report
{
    public static void GenerateExpenseReport(Voucher voucher, string expenseName)
    {
        List<ExpenseItem> list = voucher.GetExpensesByName(expenseName);

        if (list.Count == 0)
        {
            Console.WriteLine("No records found for: " + expenseName);
            return;
        }

        int total = 0;

        Console.WriteLine("\n--- Report for " + expenseName + " ---");

        foreach (ExpenseItem e in list)
        {
            Console.WriteLine(
                e.Name + " - " + e.Cost + " - " + e.Date);
            total += e.Cost;
        }

        Console.WriteLine("Total Expense: " + total);
    }
}
