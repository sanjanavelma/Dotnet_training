using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Patient
{
    public int patientId{get;}
    public string Name{get; set;}
    public int Age{get; set;}
    private string medicalHistory;
    public Patient(int id, string name, int age)
    {
        PatientId = id;
        Name = name;
        Age = age;
    }
    public void SetMedicalHistory(string history)
    {
        medicalHistory = history;
    }
    public string GetMedicalHistory()
    {
        return medicalHistory;
    }
}
public class Doctor
{
    static int TotalDoctors;
    readonly string LicenseNumber;
    public string Name{get; set;}
    
}