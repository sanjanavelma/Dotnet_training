using System;
class StudentManageProperties
{
    public int StudentID { get; set; }
    private string password;
    public string Password
    {
        set
        {
            if (value.Length >= 6)
                password = value;
            else
                Console.WriteLine("Password must be at least 6 characters.");
        }
    }
    private string name;
    public string Name
    {
        get => name;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
            else
                Console.WriteLine("Name cannot be empty.");
        }
    }
    private int age;
    public int Age
    {
        get => age;
        set
        {
            if (value > 0)
                age = value;
            else
                Console.WriteLine("Age must be greater than 0.");
        }
    }
    private int marks;
    public int Marks
    {
        get => marks;
        set
        {
            if (value >= 0 && value <= 100)
                marks = value;
            else
                Console.WriteLine("Marks must be between 0 and 100.");
        }
    }
    public string ResultStatus
    {
        get => marks >= 40 ? "Pass" : "Fail";
    }
    public string RegistrationNumber { get; private set; }
    public StudentManageProperties(string regNo)
    {
        RegistrationNumber = regNo;
        password = "";
        name = "";
    }
    public int AdmissionYear { get; init; }
    public double Percentage => (marks / 100.0) * 100; 
}

