using System;
using System.Collections;
using System.Linq;
class Program
{
    static void Main()
    {
        // EcommerceApplication e = new EcommerceApplication();
        // try
        // {
        //     e.Withdraw(600);
        // }
        // catch(InsufficientBalanceException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
        // 101:Present,102:Absent,103:Present,104:,105:Present,ABC:Present,106:Absent

        // Requirements

        // Write a C# program that:

        // Reads the input string.

        // Parses each entry safely.
        // Student s = new Student();
        // string[] input = Console.ReadLine().Split(",");
        // foreach(var v in input)
        // {
        //     string[] input2 = v.Split(":");

        //     if(!int.TryParse(input2[0], out int studentId))
        //         continue;
        //     string atten = input2[1];
        //     bool? att = null;
        //     if (atten == "Present")
        //     {
        //         att = true;
        //     }
        //     else if(atten == "Absent")
        //     {
        //         att = false;
        //     }
        //     else
        //     {
        //         att = null;
        //     }
        //     s.AddAttendence(studentId, att);
        // }
        // s.DisplayAttendence();
        // UserAuthentication ua = new UserAuthentication("Sanjana", "S@nju2003", "S@nju2004");
        // try
        // {
        //     ua.ValidatePassword();
        // }
        // catch(PasswordMismatchException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
        // ConstructionEstimate ce = new ConstructionEstimate(1000, 800, 500);
        // try
        // {
        //     Console.WriteLine(ce.ValidateAndEstimate());
        // }
        // catch(ConstructionEstimateException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
        // UserVerification uv = new UserVerification("Sanjana", "88897532632");
        // try
        // {
        //     var v = uv.ValidatePhone();
        //     Console.WriteLine($"User verified: {v.UserName} - {v.PhoneNumber}");
        // }
        // catch(InvalidPhoneNumberException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
        string input = " 24.5678, 18.9, null, , 31.0049, error, 29, 17.999, NaN ";

        SensorDataNormalizer normalizer = new SensorDataNormalizer();

        float[] output = normalizer.Normalize(input);

        if (output == null)
            Console.WriteLine("No valid data.");
        else
            Console.WriteLine("{ " + string.Join(", ", output.Select(x => x.ToString("F2"))) + " }");
    }
}