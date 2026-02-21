using System;
using System.Collections.Generic;

public class LibraryManagement
{
    // memberId -> [0] = totalPaid, [1] = totalImposed
    private Dictionary<string, long[]> members = new Dictionary<string, long[]>();

    public void AddMember(string memberId)
    {
        if (!members.ContainsKey(memberId))
        {
            members[memberId] = new long[2]; 
        }
    }

    public void ImposeFine(string memberId, long amount)
    {
        if (members.ContainsKey(memberId))
        {
            members[memberId][1] += amount; // imposed
        }
    }

    public void PayFine(string memberId, long amount)
    {
        if (members.ContainsKey(memberId))
        {
            members[memberId][0] += amount; // paid
        }
    }

    public void GetDetails(string memberId)
    {
        if (members.ContainsKey(memberId))
        {
            long paid = members[memberId][0];
            long imposed = members[memberId][1];
            long remaining = imposed - paid;

            Console.WriteLine($"{memberId} {remaining} {imposed} {paid}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        LibraryManagement lib = new LibraryManagement();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string command = input[0];

            if (command == "ADD")
            {
                lib.AddMember(input[1]);
            }
            else if (command == "IMPOSE")
            {
                lib.ImposeFine(input[1], long.Parse(input[2]));
            }
            else if (command == "PAY")
            {
                lib.PayFine(input[1], long.Parse(input[2]));
            }
            else if (command == "GETDETAILS")
            {
                lib.GetDetails(input[1]);
            }
        }
    }
}