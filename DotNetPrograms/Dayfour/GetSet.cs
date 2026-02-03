using System;
class Employee
{
    private double salary;
    public double Salary
    {
        get { return salary; }
        set
        {
            if (value > 0)
                salary = value;
        }
    }
}