using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
// Question 1: Student Attendance Analyzer

// A college stores attendance data entered by a staff member as a single line:

// 101:Present,102:Absent,103:Present,104:,105:Present,ABC:Present,106:Absent

// Requirements

// Write a C# program that:

// Reads the input string.

// Parses each entry safely.

// Stores valid student attendance in a Dictionary<int, bool?>

// Key → Student ID

// Value →

// true = Present

// false = Absent

// null = Missing attendance

// Ignore invalid IDs (like ABC).

// If attendance value is missing (example: 104:), store it as null.

// Use StringBuilder to generate the output report.

// Output Format
// Attendance Report
// -----------------
// 101 -> Present
// 102 -> Absent
// 103 -> Present
// 104 -> Not Marked
// 105 -> Present
// 106 -> Absent

// Total Present: X
// Total Absent: X
// Not Marked: X
public class Student
{
    public static Dictionary<int, bool?> attendance = new Dictionary<int, bool?>();
    public void AddAttendence(int studentId, bool? att)
    {
        attendance[studentId] = att;
    }
    public void DisplayAttendence()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Attendence Report");
        sb.AppendLine("------------------");
        foreach(var v in attendance)
        {
            string status = v.Value == true ? "Present": v.Value == false ? "Absent" : "Not Marked";
            sb.AppendLine($"{v.Key} -> {status}");
        }
        int totalPre = attendance.Count(x => x.Value == true);
        int totalAbs = attendance.Count(x => x.Value == false);
        int notMarked = attendance.Count(x => x.Value == null);

        sb.AppendLine();
        sb.AppendLine($"Total Present: {totalPre}");
        sb.AppendLine($"Total Absent: {totalAbs}");
        sb.AppendLine($"Not Marked: {notMarked}");
        Console.WriteLine(sb.ToString());
    }
}

