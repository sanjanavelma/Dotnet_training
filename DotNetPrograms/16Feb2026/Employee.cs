using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 public class Employee
{
    protected string empName;
    public Employee(string name)
    {
        empName = name;
    }
    public virtual double GetSalary()
    {
        return 0;
    }
}
public class FullTimeEmp : Employee
{
    double MonSalary;
    double Bouns;
    public FullTimeEmp(string name, double Monthly) : base(name)
    {
        MonSalary = Monthly;
        Bouns = Monthly * 0.05;
    }
    public override double GetSalary()
    {
        Console.WriteLine("Employee name: " + empName);
        return MonSalary + Bouns;
    }
}
public class PartTimeEmp : Employee
{
    double HourlyWage;
    int Totalhr;
    public PartTimeEmp(string name, double wage, int hr) : base(name)
    {
        HourlyWage = wage;
        Totalhr = hr;
    }
    public override double GetSalary()
    {
        Console.WriteLine("Employee name: " + empName);
        return HourlyWage * Totalhr;
    }
}