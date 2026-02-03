using System;
using System.Collections.Generic;
namespace _10Jan2026.DialingCodesApp
{
    class program
    {
        static void Main()
        {
            //Task 1
            var emptyDict = DialingCodes.GetEmptyDictionary();
            Console.WriteLine("Task 1: Empty Dictionary = " + emptyDict.Count);
            //Task2 
            var existingDict = DialingCodes.GetExistingDictionary();
            Console.WriteLine("\n Task 2: Existing Dictionary");
            PrintDictionary(existingDict);
            //Task 3
            var singleCountry = DialingCodes.AddCountryToEmptyDictionary(81, "Japan");
            Console.WriteLine("\n Task 3: Add Country to Empty Dictionary");
            PrintDictionary(singleCountry);
            // Task 4: Add Country to Existing Dictionary
            DialingCodes.AddCountryToExistingDictionary(existingDict, 44, "United Kingdom");
            Console.WriteLine("\nTask 4: Add Country to Existing Dictionary");
            PrintDictionary(existingDict);
            // Task 5: Get Country Name
            Console.WriteLine("\nTask 5: Get Country Name");
            Console.WriteLine("Code 91: " + DialingCodes.GetCountryNameFromDictionary(existingDict, 91));
            Console.WriteLine("Code 99: " + DialingCodes.GetCountryNameFromDictionary(existingDict, 99));
            // Task 6: Check Code Exists
            Console.WriteLine("\nTask 6: Check Code Exists");
            Console.WriteLine("Code 1 exists? " + DialingCodes.CheckCodeExists(existingDict, 1));
            Console.WriteLine("Code 999 exists? " + DialingCodes.CheckCodeExists(existingDict, 999));
            // Task 7: Update Existing Country
            DialingCodes.UpdateDictionary(existingDict, 91, "Republic of India");
            Console.WriteLine("\nTask 7: Update Existing Country");
            PrintDictionary(existingDict);
            // Task 8: Remove Country
            DialingCodes.RemoveCountryFromDictionary(existingDict, 1);
            Console.WriteLine("\nTask 8: Remove Country");
            PrintDictionary(existingDict);
            // Task 9: Find Longest Country Name
            Console.WriteLine("\nTask 9: Longest Country Name");
            Console.WriteLine(DialingCodes.FindLongestCountryName(existingDict));
            Console.WriteLine();
        }
        // Helper method to print dictionary
        static void PrintDictionary(Dictionary<int, string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}