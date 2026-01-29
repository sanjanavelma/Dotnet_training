using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<Student> Students = new List<Student>
        {
            new Student{Name = "Sanjana", Age = 21, Marks = 98},
            new Student{Name = "Ashi Gupta", Age = 22, Marks = 98},
            new Student{Name = "Raima", Age = 22, Marks = 99}
        };
        // var SortedStudents = Students
        //     .OrderByDescending(s => s.Marks)
        //     .ThenBy(s => s.Age)
        //     .ToList();
        // Console.WriteLine("SortedList:\n");
        Students.Sort(new StudentComparer());
        foreach (var s in Students)
        {
            Console.WriteLine($"Name: {s.Name}, Age: {s.Age}, Marks: {s.Marks}");
        }
        Console.WriteLine();
    }
}
