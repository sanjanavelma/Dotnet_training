using System;
using System.Collections.Generic;


public class User
{
    public int Id{get;set;}
    public string Name{get;set;}
}
class Program
{
            public static bool ScholarshipEligibility(Student std)
        {
           if(std.Marks>80 && std.SportGrade=='A')
                return true;
            return false;
    }
    static void Main()
    {
        Console.WriteLine("Enter the Number of Students: ");
        int n = Convert.ToInt32(Console.ReadLine());
        List<Student> list = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            Student s = new Student();
            Console.WriteLine("Enter the Roll no of Student: ");
            s.RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name of Student: ");
            s.Name = Console.ReadLine();
            Console.WriteLine("Enter the Marks of the Student" );
            s.Marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Grade of the Student: ");
            s.SportGrade = Console.ReadLine()[0];

            list.Add(s);
        }
        string result=Student.GetEligibleStudents(list,ScholarshipEligibility);
        Console.WriteLine (result);

    }
}