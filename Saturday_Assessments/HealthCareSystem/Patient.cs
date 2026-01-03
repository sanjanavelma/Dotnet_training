using System;
using System.Collections.Generic;

public class Patient
{
    public readonly int PatientId;
    public string Name { get; set; }
    public int Age { get; set; }
    private string medicalHistory;
    public string Gender { get; set; }
    public string Contact { get; set; }
    public string Status { get; private set; } = "OPD";
    public bool IsEmergency { get; private set; }

    public Patient(int id, string name, int age, string gender, string contact)
    {
        PatientId = id;
        Name = name;
        Age = age;
        Gender = gender;
        Contact = contact;
    }

    public void SetMedicalHistory(string history)
    {
        medicalHistory = history;
    }

    public string GetMedicalHistory()
    {
        return medicalHistory;
    }

    public void UpdateStatus(string status)
    {
        Status = status;
    }

    public void FlagEmergency()
    {
        IsEmergency = true;
    }

    public void PrintPatientCard()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("        PATIENT CARD");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Patient ID: " + PatientId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Gender: " + Gender);
        Console.WriteLine("Contact: " + Contact);
        Console.WriteLine("Status: " + Status);
        Console.WriteLine("Emergency: " + (IsEmergency ? "YES" : "NO"));
        Console.WriteLine("---------------------------------");
    }
}

public static class PatientModule
{
    static List<Patient> patients = new List<Patient>();

    public static void PatientMenu()
    {
        bool run = true;
        while (run)
        {
            Console.Clear();
            Console.WriteLine("----- PATIENT MANAGEMENT -----");
            Console.WriteLine("1. Register Patient");
            Console.WriteLine("2. View Patient Card");
            Console.WriteLine("3. Update Patient Status");
            Console.WriteLine("4. Flag Emergency");
            Console.WriteLine("5. Back");
            Console.Write("Enter choice: ");
            string ch = Console.ReadLine();

            switch (ch)
            {
                case "1":
                    RegisterPatient();
                    break;
                case "2":
                    ViewPatientCard();
                    break;
                case "3":
                    UpdateStatus();
                    break;
                case "4":
                    EmergencyFlag();
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

    static void RegisterPatient()
    {
        Console.Write("Enter Patient ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Gender: ");
        string gender = Console.ReadLine();
        Console.Write("Enter Contact: ");
        string contact = Console.ReadLine();
        Console.Write("Enter Medical History: ");
        string history = Console.ReadLine();

        Patient p = new Patient(id, name, age, gender, contact);
        p.SetMedicalHistory(history);
        patients.Add(p);

        Console.WriteLine("Patient Registered Successfully");
        Console.ReadKey();
    }

    static Patient FindPatient()
    {
        Console.Write("Enter Patient ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        return patients.Find(p => p.PatientId == id);
    }

    static void ViewPatientCard()
    {
        Patient p = FindPatient();
        if (p == null)
        {
            Console.WriteLine("Patient Not Found");
        }
        else
        {
            p.PrintPatientCard();
            Console.WriteLine("Medical History (Secure Access): " + p.GetMedicalHistory());
        }
        Console.ReadKey();
    }

    static void UpdateStatus()
    {
        Patient p = FindPatient();
        if (p == null)
        {
            Console.WriteLine("Patient Not Found");
        }
        else
        {
            Console.Write("Enter Status (OPD/Admitted/Discharged): ");
            string status = Console.ReadLine();
            p.UpdateStatus(status);
            Console.WriteLine("Status Updated");
        }
        Console.ReadKey();
    }

    static void EmergencyFlag()
    {
        Patient p = FindPatient();
        if (p == null)
        {
            Console.WriteLine("Patient Not Found");
        }
        else
        {
            p.FlagEmergency();
            Console.WriteLine("Emergency Flag Activated");
        }
        Console.ReadKey();
    }
}
