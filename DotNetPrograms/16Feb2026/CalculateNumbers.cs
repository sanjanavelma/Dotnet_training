using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CalculateNumbers
{
    public static List<int> Numbers = new List<int>();
    public static void AddNumber(int score)
    {
        if(score >= 0 && score <= 100)
        {
           Numbers.Add(score); 
        }
        else
        {
            Console.WriteLine("Score must be between 0 to 100..");
        }
    }
    public static double CalculateGPA()
    {
        if(Numbers.Count > 0) 
        { 
            return Numbers.Average(); 
        } 
        else 
        { 
            return 0; 
        }
    }
    public static char GetGrade(double gpa)
    {
        if (gpa >= 90) return 'A';
        else if (gpa >= 80) return 'B';
        else if (gpa >= 70) return 'C';
        else if (gpa >= 60) return 'D';
        else return 'F';
    }
}
