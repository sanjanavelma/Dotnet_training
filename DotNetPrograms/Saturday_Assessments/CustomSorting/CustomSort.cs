public class Student
{
    public string Name{get; set;}
    public int Age{get; set;}
    public int Marks{get; set;}
}
public class StudentComparer : IComparer<Student>
{
    public int Compare(Student? x, Student? y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;

        int marksCompare = y.Marks.CompareTo(x.Marks);
        if (marksCompare != 0)
            return marksCompare;
        return x.Age.CompareTo(y.Age);
    }
}