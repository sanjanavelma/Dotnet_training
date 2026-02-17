using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        HospitalManager hm = new HospitalManager();
        hm.RegisterPatient(1, "Sanjana", 21, "Dying");
        hm.RegisterPatient(2, "Ashi", 22, "Cold");
        hm.RegisterPatient(3, "Raima", 22, "Cold");
        hm.ScheduleAppointment(1);
        hm.ScheduleAppointment(3);

        Console.WriteLine("Processing appointment: ");
        Patient p = hm.ProcessNextAppointment();
        Console.WriteLine($"{p.Name} - {p.Condition}");

        Console.WriteLine("Patients with Cold: ");
        var Coldp = hm.FindPatientsByCondition("Cold");
        foreach(var c in Coldp)
        {
            Console.WriteLine(c.Name);
        }
    }
}