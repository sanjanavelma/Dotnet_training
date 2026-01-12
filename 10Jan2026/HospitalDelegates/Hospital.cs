using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public delegate string ReportGenerator(string patientName);

public delegate void HospitalAlert(string message);

public delegate void HospitalNotificationHandler(string message, DateTime time);

public class HospitalNotifier
{
    public event HospitalNotificationHandler PatientAdmitted;
    public void AdmitPatient(string name)
    {
        PatientAdmitted?.Invoke(
            $"Patient {name} admitted successfully.",
            DateTime.Now
        );
    }
}
public class AdministrationDepartment
{
    public void Notify(string message, DateTime time)
    {
        Console.WriteLine($"[ADMIN] {message} | {time}");
    }
}
