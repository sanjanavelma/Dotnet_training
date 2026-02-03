using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class EmailCheck
{
    public static void EC()
    {
        List<string> emails = new List<string>
        {
            "john.doe@gmail.com",
            "alice_123@yahoo.in",
            "mark.smith@company.com",
            "support-abc@banking.co.in",
            "user.nametag@domain.org",
            "john.doe@gmail",          // Missing domain extension
            "alice@@yahoo.com",        // Double @
            "mark.smith@.com",         // Domain missing name
            "support@banking..com",    // Double dot in domain
            "user name@edu.au",     // Space not allowed
            "@domain.com",             // Missing username
            "admin@domain",            // No top-level domain
            "info@domain,com",         // Comma instead of dot
            "finance#dept@corp.com",   // Invalid character #
            "plainaddress"             // Missing @ and domain

        };

        string pattern = @"\b[\w.-]+@[\w-]+(\.[A-Za-z]{2,})+$";
        foreach (var email in emails)
        {
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine($"{email}  → Valid Email");
            }
            else
            {
                Console.WriteLine($"{email}  → Invalid Email");
            }
        }
    }
}
 