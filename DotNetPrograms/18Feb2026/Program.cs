using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
// class Program
// {
//     public static string[] GenerateMessage(Dictionary<string, double> participants)
//     {
//         string[] msgs = new string[participants.Count];
//         int i = 0;
//         foreach(var e in participants)
//         {
//             msgs[i] = $@"Dear {e.Key}, 
// Thank you for your participation in the Purchase Pleasure Festival. Your total purchase amount is ${e.Value}. We appreciate your contribution.";
//             i++;
//         }
//         return msgs;
//     }
//     static void Main()
//     {
//        Console.WriteLine("Enter the no of codes: ");
//      int n = int.Parse(Console.ReadLine());
//      Console.WriteLine("Enter the codes: ");
//      string[] code = new string[n];
//      for(int i = 0; i < n; i++)
//      {
//          code[i] = Console.ReadLine();
//      }
//      foreach(var v in code)
//      {
//          Console.WriteLine(StringValidation.Validate(v));
//      }
//         Dictionary<string, double> Participant = new Dictionary<string, double>();
//         Console.WriteLine("Enter participant data (name and amount), or type 'done' to finish: ");
//         while(true)
//         {
//             Console.WriteLine("Name: ");
//             string Name = Console.ReadLine();
//             if(Name.ToLower() == "done")
//             {
//                 break;
//             }
//             Console.WriteLine("Amount: ");
//             double Amount = double.Parse(Console.ReadLine());
//             Participant[Name] = Amount;
//             Console.WriteLine("Do you want to continue? (Y/N)");
//             string c = Console.ReadLine();
//             if(c.ToUpper() != "Y")
//             {
//                 break;
//             }
//         }    
//         string[] msg = GenerateMessage(Participant);
//         foreach(var v in msg)
//         {
//             Console.WriteLine(v);
//         }       
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         string input="The topics are generated randomly and are not tailored to the writer's preferences or the intended audience";
//         //Find the second largest string 
//         //Expected output=generated
//         string[] input2 = input.Split(" ");
//         var s = input2.OrderByDescending(x => x.Length).Take(2).ToList();
//         Console.WriteLine(s[1]);
//     }
// }
public class Program
{
    public static void Main()
    {
       string[] input = Console.ReadLine().Split(" ");
       Jewellery j = new Jewellery()
       {
           Id = input[0],
           Type = input[1],
           Material = input[2],
           Price = int.Parse(input[3])
       };
       while(true)
        {
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                JewelleryUtility.GetJewelleryDetails(j
                );
            }
            else if(choice == 2)
            {
                int newp = int.Parse(Console.ReadLine());
                JewelleryUtility.UpdateJewelleryPrice(j, newp);
            }
            else if(choice == 3)
            {
                Console.WriteLine("Thank You");
                break;
            }
        }
    }
}
