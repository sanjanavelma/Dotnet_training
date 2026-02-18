using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Student Height Processing Utility
// A training institute receives temporary student records from an old system stored in a non-generic ArrayList. The data is inconsistent and may contain missing values.
// You must write a C# program to clean and display this information.
// Requirements
// Create a Student class with the following properties:
// Id (int)
// Name (string)
// Height (float?) → height can be null
// AttendancePercentage (float)

public class Student
{
    public int Id{get; set;}
    public string Name{get; set;}
    public float? Height{get; set;}
    public float Attendanceper{get; set;}
}
