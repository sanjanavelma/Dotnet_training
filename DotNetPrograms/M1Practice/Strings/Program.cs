using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// class Program
// {
//     static void Main()
//     {
//         Helloworld.StringManipulation("   hello world from csharp   ");
//     }
// }
// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static long ToSortableNumber(string date, string time)
//     {
//         var d = date.Split('-');
//         var t = time.Split(':');

//         string key =
//             d[2] +          // year
//             d[1].PadLeft(2,'0') +
//             d[0].PadLeft(2,'0') +
//             t[0].PadLeft(2,'0') +
//             t[1].PadLeft(2,'0');

//         return long.Parse(key);
//     }

//     static List<List<string>> extractErrorLogs(List<List<string>> logs)
//     {
//         return logs
//             .Where(log => log[2] == "ERROR" || log[2] == "CRITICAL")
//             .Select((log, index) => new
//             {
//                 Log = log,
//                 Key = ToSortableNumber(log[0], log[1]),
//                 OriginalIndex = index
//             })
//             .OrderBy(x => x.Key)
//             .ThenBy(x => x.OriginalIndex) // stable sort
//             .Select(x => x.Log)
//             .ToList();
//     }

//     static void Main()
//     {
//         var logs = new List<List<string>>
//         {
//             new List<string>{"02-01-2023","1:30","ERROR","failed"},
//             new List<string>{"01-01-2023","04:00","INFO","established"},
//             new List<string>{"01-01-2023","14:00","CRITICAL","crash"}
//         };

//         var result = extractErrorLogs(logs);

//         foreach (var r in result)
//             Console.WriteLine(string.Join(" | ", r));
//     }
// }
// In Main(), create a List<Student> and add at least 5 students.
// At least one student must have null Height
// Use float values such as 165.5, 172.75, etc.
// Convert the List<Student> into an ArrayList to simulate legacy storage.
// Process the ArrayList and display:
// a) If Height is null, display "Height Not Available"
// b) If Height has value, print the height rounded to 1 decimal place
// c) Print the student's name using alternate characters only
// (Example: "Karthikeyan" → "Krhkean")
// d) Display AttendancePercentage only if it is greater than 75.5

// Finally, display the total number of students whose attendance was displayed.
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student{Id = 1, Name = "Sanjana", Height = 155.5f, Attendanceper = 80},
            new Student{Id = 2, Name = "Ashi", Height = 152.0f, Attendanceper = 90},
            new Student{Id = 3, Name = "Raima", Height = 145.2f, Attendanceper = 60},
            new Student{Id = 4, Name = "Shahid", Height = 165.6f, Attendanceper = 40},
            new Student{Id = 5, Name = "Saibaba", Height = null, Attendanceper = 70},
            new Student{Id = 4, Name = "Pinky", Height = 165.5f, Attendanceper = 95}
        };
        ArrayList legacy = new ArrayList(students);
        int attendanceCount = 0;
        foreach(Student s in legacy)
        {
            Console.WriteLine($"student: {s.Name}");
            if(s.Height == null)
            {
                Console.WriteLine("Height: Height not Available");
            }
            else
            {
                Console.WriteLine("Height: " + Math.Round(s.Height.Value, 1));
            }
            string alt = "";
            for(int i =  0; i < s.Name.Length; i += 2)
            {
                alt += s.Name[i];
            }
            Console.WriteLine("Alt Name: " + alt);
            if(s.Attendanceper > 75.5)
            {
                Console.WriteLine("Attendance: " + s.Attendanceper);
                attendanceCount ++;
            }
        }
        Console.WriteLine("Total displayed attendance: " + attendanceCount);
    }
}