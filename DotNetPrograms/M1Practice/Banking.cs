// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// public class Debit
// {
//     public void DebitMenu()
//     {
//         int option;
//         do
//         {
//             Console.WriteLine("\n--- Debit Operation ---");
//             Console.WriteLine("1. ATM Withdral Limit Validation");
//             Console.WriteLine("2. EMI Burden Evaluation");
//             Console.WriteLine("3. Daily Spending Calculator");
//             Console.WriteLine("4. Minimum Balance Check");
//             Console.WriteLine("5. Back to Main Menu");
//             Console.Write("Enter option: ");
//             option = int.Parse(Console.ReadLine());
//             switch (option)
//             {
//                 case 1:
//                     ATMWithDrawalLimit();
//                     break;
//                 case 2:
//                     EMIBurdenEvaluation();
//                     break;
//                 case 3:
//                     TransactionBasedDaily();
//                     break;
//                 case 4:
//                     MinimunBalanceCheck();
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//             }

//         }while(option != 5);
//     }
//     public void ATMWithDrawalLimit()
//     {
//         Console.WriteLine("Enter withdrawal amount: ");
//         double amount = double.Parse(Console.ReadLine());
//         if (withdrawal <= 40000)
//         {
//             Console.WriteLine("Withdrawal premitted within daily limit.");
//         }
//         else
//         {
//             Console.WriteLine("Daily ATM withdrawal limit exceeded.");
//         }
//     }
//     public void EMIBurdenEvaluation()
//     {
//         Console.WriteLine("Enter Monthly income: ");
//         double monthlyincome = double.Parse(Console.ReadLine());
//         Console.WriteLine("Enter EMI amount: ");
//         double EMIamo = double.Parse(Console.ReadLine());
//         if(EMIamo <= income * 0.40)
//         {
//             Console.WriteLine("EMI is financially manageable.");
//         }
//         else
//         {
//             Console.WriteLine("EMI exceeds safe income limit.");
//         }
//     }
//     public void TransactionBasedDaily()
//     {
//         Console.WriteLine("Enter number of transactions: ");
//         int Transactions = int.Parse(Console.ReadLine());
//         double total = 0;
//         for(int i = 0; i <= Transaction; i++)
//         {
//             Console.WriteLine("Enter amount for transaction" + i + ":");
//             double amt = double.Parse(Console.ReadLine());
//             total += amt;
//         }
//     }
//     public void MinimunBalanceCheck()
//     {
//         Console.WriteLine("Enter current balance: ");
//         double CurrBal = double.Parse(Console.ReadLine());
//         if(CurrBal < 2000)
//         {
//             Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
//         }
//         else
//         {
//             Console.WriteLine("Minimum balance requirement satisfied.");
//         }
//     }
// }
