using System;
using System.Collections.Generic;
public class Doctor
{
    public string Name { get; set; }
    public string Specialization { get; set; }
    public int Experience { get; set; }
    public readonly int LicenseNumber;
    public static int TotalDoctors;
    public bool IsAvailable { get; private set; } = true;
    public string ShiftTiming { get; private set; } = "General";
    private List<int> assignedPatients = new List<int>();
    public double PerformanceRating { get; private set; }
    static Doctor()
    {
        TotalDoctors = 0;
    }
    public Doctor(string name, string spec, int exp, int license)
    {
        Name = name;
        Specialization = spec;
        Experience = exp;
        LicenseNumber = license;
        TotalDoctors++;
    }
    public void SetAvailability(bool status)
    {
        IsAvailable = status;
    }
    public void SetShift(string shift)
    {
        ShiftTiming = shift;
    }
    public void AssignPatient(int patientId)
    {
        assignedPatients.Add(patientId);
    }
    public void SetRating(double rating)
    {
        PerformanceRating = rating;
    }
    public void PrintDoctorCard()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("          DOCTOR PROFILE");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Specialization: " + Specialization);
        Console.WriteLine("Experience: " + Experience + " years");
        Console.WriteLine("License Number: " + LicenseNumber);
        Console.WriteLine("Availability: " + (IsAvailable ? "Available" : "Not Available"));
        Console.WriteLine("Shift: " + ShiftTiming);
        Console.WriteLine("Assigned Patients: " + (assignedPatients.Count == 0 ? "None" : string.Join(", ", assignedPatients)));
        Console.WriteLine("Performance Rating: " + (PerformanceRating == 0 ? "Not Rated" : PerformanceRating));
        Console.WriteLine("---------------------------------");
    }
}
public static class DoctorModule
{
    static List<Doctor> doctors = new List<Doctor>();
    public static void DoctorMenu()
    {
        bool run = true;
        while (run)
        {
            Console.Clear();
            Console.WriteLine("----- DOCTOR MANAGEMENT -----");
            Console.WriteLine("1. Register Doctor");
            Console.WriteLine("2. View Doctor Profile");
            Console.WriteLine("3. Set Availability");
            Console.WriteLine("4. Set Shift Timing");
            Console.WriteLine("5. Assign Patient to Doctor");
            Console.WriteLine("6. Set Performance Rating");
            Console.WriteLine("7. View Total Doctors");
            Console.WriteLine("8. Back");
            Console.Write("Enter choice: ");

            switch (Console.ReadLine())
            {
                case "1": RegisterDoctor(); break;
                case "2": ViewDoctor(); break;
                case "3": SetAvailability(); break;
                case "4": SetShift(); break;
                case "5": AssignPatient(); break;
                case "6": SetRating(); break;
                case "7": ShowTotalDoctors(); break;
                case "8": run = false; break;
                default: Console.WriteLine("Invalid"); Console.ReadKey(); break;
            }
        }
    }
    static void RegisterDoctor()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Specialization: ");
        string spec = Console.ReadLine();
        Console.Write("Enter Experience (years): ");
        int exp = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter License Number: ");
        int license = Convert.ToInt32(Console.ReadLine());
        Doctor d = new Doctor(name, spec, exp, license);
        doctors.Add(d);
        Console.WriteLine("Doctor Registered Successfully");
        Console.ReadKey();
    }
    static Doctor FindDoctor()
    {
        Console.Write("Enter License Number: ");
        int lic = Convert.ToInt32(Console.ReadLine());
        return doctors.Find(d => d.LicenseNumber == lic);
    }
    static void ViewDoctor()
    {
        Doctor d = FindDoctor();
        if (d == null) 
        {
            Console.WriteLine("Doctor Not Found");
        }
        else 
        {
            d.PrintDoctorCard();
        }
        Console.ReadKey();
    }
    static void SetAvailability()
    {
        Doctor d = FindDoctor();
        if (d == null) 
        {
            Console.WriteLine("Doctor Not Found");
        }
        else
        {
            Console.Write("Enter Availability (true/false): ");
            bool status = Convert.ToBoolean(Console.ReadLine());
            d.SetAvailability(status);
            Console.WriteLine("Availability Updated");
        }
        Console.ReadKey();
    }
    static void SetShift()
    {
        Doctor d = FindDoctor();
        if (d == null) 
        {
            Console.WriteLine("Doctor Not Found");
        }
        else
        {
            Console.Write("Enter Shift (Morning/Evening/Night): ");
            d.SetShift(Console.ReadLine());
            Console.WriteLine("Shift Updated");
        }
        Console.ReadKey();
    }
    static void AssignPatient()
    {
        Doctor d = FindDoctor();
        if (d == null) Console.WriteLine("Doctor Not Found");
        else
        {
            Console.Write("Enter Patient ID to Assign: ");
            int pid = Convert.ToInt32(Console.ReadLine());
            d.AssignPatient(pid);
            Console.WriteLine("Patient Assigned");
        }
        Console.ReadKey();
    }
    static void SetRating()
    {
        Doctor d = FindDoctor();
        if (d == null) Console.WriteLine("Doctor Not Found");
        else
        {
            Console.Write("Enter Rating (0–5): ");
            double r = Convert.ToDouble(Console.ReadLine());
            d.SetRating(r);
            Console.WriteLine("Rating Updated");
        }
        Console.ReadKey();
    }
    static void ShowTotalDoctors()
    {
        Console.WriteLine("Total Doctors: " + Doctor.TotalDoctors);
        Console.ReadKey();
    }
}
