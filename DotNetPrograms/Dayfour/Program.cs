using System;
class Program
{
    static void Main()
    {
        // DiffConstructor obj = new DiffConstructor();

        // FixedDeposit fd1 = new FixedDeposit();

        // Product p = new Product("Laptop", 50000);
        // Console.WriteLine(p.Name);
        // Console.WriteLine(p.Price);
        //===================================================================//
        // Employee emp = new Employee();
        // emp.Salary = 50000;   // valid
        // emp.Salary = -2000;   // ignored
        // Console.WriteLine(emp.Salary);
        //================================================================//
        /*Student s = new Student();
        Console.WriteLine("Enter the name:");
        s.Name = Console.ReadLine();
        Console.WriteLine("Enter the Age:");
        s.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Marks:");
        s.Marks = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name: " + s.Name);
        Console.WriteLine("Age: " + s.Age);
        Console.WriteLine("Marks: " + s.Marks);*/
        //==============================================================//
        /*StudentManageProperties s = new StudentManageProperties("12219972")
        {
            StudentID = 101,
            Name = "Sanjana",
            Age = 21,
            Marks = 85,
            AdmissionYear = 2023
        };
        s.Password = "S@nju2004";
        Console.WriteLine("\n-------- Student Details --------");
        Console.WriteLine($"Student ID         : {s.StudentID}");
        Console.WriteLine($"Registration No    : {s.RegistrationNumber}");
        Console.WriteLine($"Name               : {s.Name}");
        Console.WriteLine($"Age                : {s.Age}");
        Console.WriteLine($"Marks              : {s.Marks}");
        Console.WriteLine($"Result             : {s.ResultStatus}");
        Console.WriteLine($"Admission Year     : {s.AdmissionYear}");
        Console.WriteLine($"Percentage         : {s.Percentage}%");*/
        //====================================================================//
        // EmployeeDirectory ed = new EmployeeDirectory();
        // ed[101] = "Sanjana";
        // Console.WriteLine(ed[101]);
        // Console.WriteLine(ed["Ravi"]);
        //=====================================================================//
    //  LibraryManagementSystem Lb = new LibraryManagementSystem();
    //  Lb[101] = "Fundamentals of C#";
    //  Lb[102] = "Rythms of Rainbow";
    //  Lb[103] = "Properties of ART";
    //  Console.WriteLine("------ Access Using Book ID ------");
    //  Console.WriteLine(Lb[101]);
    //  Console.WriteLine(Lb[102]);
    //  Console.WriteLine(Lb[103]);
        // Students s = new Students("sanjana", 101);
        // Console.WriteLine(s.Name);
        // Console.WriteLine(s.RollNo);
        // Car c = new Car();
        // c.Start();   // inherited method
        // c.Drive();   // own method
    //=========================================================================//
        Security sec = new Security();
        sec.Authenticate();
        LifeInsurance L = new LifeInsurance(102, "Sanjana", 5000);
        HealthInsurance H = new HealthInsurance(205, "Sathvika", 5000);
        PolicyDirectory D = new PolicyDirectory();
        D.AddPolicy(L);
        D.AddPolicy(H);
        InsurancePolicy p1 = L;
        InsurancePolicy p2 = H;
        Console.WriteLine(D[0].PolicyHolderName);
        var policy = D["Sanjana"];
        if (policy != null)
        {
            Console.WriteLine(policy.PolicyNumber);
        }
        else
        {
            Console.WriteLine("Policy not found");
        }
        Console.WriteLine("Life Premium: " + p1.CalculatePremium());
        Console.WriteLine("Health Premium: " + p2.CalculatePremium());
        L.ShowPolicy();           // Derived reference
        p1.ShowPolicy();             // Base reference
        //==================================================================//
    }

}
