using System;
public class Appointment
{
    public int AppointmentId { get; }
    public Patient Patient { get; private set; }
    public Doctor Doctor { get; private set; }
    public DateTime AppointmentDate { get; private set; }
    public string Mode { get; private set; }
    public string Status { get; private set; }
    private static int counter = 1000;
    public Appointment()
    {
        AppointmentId = ++counter;
        Status = "Pending";
        Mode = "Offline";
        AppointmentDate = DateTime.Now.AddDays(1);
    }
    public void Schedule(Patient p, Doctor d)
    {
        Patient = p;
        Doctor = d;
        Status = "Scheduled";
        Console.WriteLine("Appointment Scheduled");
        Console.WriteLine($"Patient: {p.Name}");
        Console.WriteLine($"Doctor: {d.Name}");
    }
    public void Schedule(Patient p, Doctor d, DateTime date, string mode = "Offline")
    {
        Patient = p;
        Doctor = d;
        AppointmentDate = date;
        Mode = mode;
        Status = "Scheduled";

        Console.WriteLine("Appointment Scheduled with Details");
        Console.WriteLine($"Patient: {p.Name}");
        Console.WriteLine($"Doctor: {d.Name}");
        Console.WriteLine($"Date: {date.ToString("f")}");
        Console.WriteLine($"Mode: {Mode}");
    }
    public void Cancel()
    {
        Status = "Cancelled";
        Console.WriteLine($"Appointment {AppointmentId} Cancelled");
    }
    public void PrintSummary()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("        APPOINTMENT SUMMARY");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Appointment ID: {AppointmentId}");
        Console.WriteLine($"Patient: {Patient?.Name}");
        Console.WriteLine($"Doctor: {Doctor?.Name}");
        Console.WriteLine($"Date: {AppointmentDate.ToString("f")}");
        Console.WriteLine($"Mode: {Mode}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine("---------------------------------");
    }
}
public static class AppointmentModule
{
    static List<Appointment> appointments = new List<Appointment>();
    public static void AppointmentMenu()
    {
        bool run = true;
        while (run)
        {
            Console.Clear();
            Console.WriteLine("----- APPOINTMENT MANAGEMENT -----");
            Console.WriteLine("1. Create Appointment (Basic)");
            Console.WriteLine("2. Create Appointment (With Date & Mode)");
            Console.WriteLine("3. View Appointment");
            Console.WriteLine("4. Cancel Appointment");
            Console.WriteLine("5. Back");
            Console.Write("Enter choice: ");
            switch (Console.ReadLine())
            {
                case "1": 
                BasicAppointment(); 
                break;
                case "2": 
                AdvancedAppointment(); 
                break;
                case "3": 
                ViewAppointment(); 
                break;
                case "4": 
                CancelAppointment(); 
                break;
                case "5":
                run = false; 
                break;
                default:
                    Console.WriteLine("Invalid");
                    Console.ReadKey();
                    break;
            }
        }
    }
    static void BasicAppointment()
    {
        Console.Write("Enter Patient ID: ");
        int pid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Doctor License: ");
        int lic = Convert.ToInt32(Console.ReadLine());
        Appointment a = new Appointment();
        a.Schedule(
            new Patient(pid, "Temp", 20, "NA", "NA"),
            new Doctor("TempDoctor", "NA", 1, lic)
        );
        appointments.Add(a);
        Console.WriteLine("Appointment Created Successfully");
        Console.ReadKey();
    }
    static void AdvancedAppointment()
    {
        Console.Write("Enter Patient ID: ");
        int pid = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Doctor License: ");
        int lic = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Date (yyyy-mm-dd): ");
        DateTime date = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Enter Mode (Online/Offline): ");
        string mode = Console.ReadLine();
        Appointment a = new Appointment();
        a.Schedule(
            new Patient(pid, "Temp", 20, "NA", "NA"),
            new Doctor("TempDoctor", "NA", 1, lic),
            date,
            mode
        );
        appointments.Add(a);
        Console.WriteLine("Appointment Scheduled Successfully");
        Console.ReadKey();
    }
    static void ViewAppointment()
    {
        Console.Write("Enter Appointment ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Appointment a = appointments.Find(x => x.AppointmentId == id);

        if (a == null)
            Console.WriteLine("Appointment Not Found");
        else
            a.PrintSummary();

        Console.ReadKey();
    }
    static void CancelAppointment()
    {
        Console.Write("Enter Appointment ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Appointment a = appointments.Find(x => x.AppointmentId == id);
        if (a == null)
            Console.WriteLine("Appointment Not Found");
        else
        {
            a.Cancel();
            Console.WriteLine("Appointment Cancelled");
        }
        Console.ReadKey();
    }
}
