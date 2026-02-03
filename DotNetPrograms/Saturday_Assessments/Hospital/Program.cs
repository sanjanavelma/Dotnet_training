using System;

class Program
{
    static void Main(string[] args)
    {
        HospitalSystem hs = null;

        Console.WriteLine();
        Patient patient = new Patient(1, "Aarav", 65);
        patient.SetMedicalHistory("Diabetes, Hypertension");

        Console.WriteLine($"Patient ID: {patient.PatientId}");
        Console.WriteLine($"Patient Name: {patient.Name}");
        Console.WriteLine($"Patient Age: {patient.Age}");
        Console.WriteLine(patient.GetMedicalHistory());

        Console.WriteLine();
        Doctor generalDoctor = new Doctor("Dr. Mehta", "General Medicine", 1111);

        Console.WriteLine($"Doctor Name: {generalDoctor.Name}");
        Console.WriteLine($"Specialization: {generalDoctor.Specialization}");
        Console.WriteLine($"License No: {generalDoctor.LicenseNumber}");
        Console.WriteLine($"Total Doctors: {Doctor.TotalDoctors}");
        Cardiologist cardiologist = new Cardiologist("Dr. Sharma", 2222);

        Console.WriteLine();
        AppointmentScheduler scheduler = new AppointmentScheduler();

        scheduler.ScheduleAppointment(patient, cardiologist);
        Console.WriteLine();

        scheduler.ScheduleAppointment(
            patient,
            cardiologist,
            DateTime.Now.AddDays(1),
            "Online"
        );
        MedicalRecord record = new MedicalRecord();
        record.SetRecord("Heart Disease", "Chest pain and fatigue");

        Console.WriteLine(record.GetDiagnosis());
        Console.WriteLine(record.GetHistory());
        DiagnosisService diagnosisService = new DiagnosisService();

        int age = patient.Age;
        string condition = "";
        string riskLevel;

        diagnosisService.EvaluatePatient(
            in age,
            ref condition,
            out riskLevel,
            85, 78, 90
        );

        Console.WriteLine($"Condition: {condition}");
        Console.WriteLine($"Risk Level: {riskLevel}");
        BillingService billing = new BillingService
        {
            ConsultationFee = 500,
            TestCharges = 2000,
            RoomCharges = 3000
        };

        double totalBill = billing.CalculateBill();
        Console.WriteLine($"Total Bill: {totalBill}");

        double billAfterDiscount = billing.CalculateBill(500);
        Console.WriteLine($"After Discount: {billAfterDiscount}");

        double billWithTax = billing.CalculateBill(500, 200);
        Console.WriteLine($"After Discount + Tax: {billWithTax}");
        InsuranceService insurance = new InsuranceService();
        double finalPayable = insurance.ApplyInsurance(20, billWithTax);

        Console.WriteLine($"Final Payable After Insurance: {finalPayable}");

        StayCalculator stay = new StayCalculator();
        Console.WriteLine($"Total Stay Days: {stay.CalculateStayDays(5)}");
        InputValidator validator = new InputValidator();

        try
        {
            int validAge = validator.ReadAge("45");
            Console.WriteLine($"Validated Age: {validAge}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("\nHospital System Execution Completed Successfully.");
    }
}
