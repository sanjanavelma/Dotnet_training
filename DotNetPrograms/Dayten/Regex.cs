// using System;
// using System.Text.RegularExpressions;
// public class RegexisMatch
//     {
//         public static void re()
//     {
//         //string sent = "_abc_"; False
//         // string sent = "_abc9_"; //True
//         string pattern = @"\d";
//         bool result = Regex.IsMatch(sent, pattern);
//         Console.WriteLine(result);
//     }
//     }
// public class RegexMatch
// {
//     public static void res()
//     {
//         //string sents = "?10A20B30C!@_abc _0!\t";
//         //string sents = "HelloC:\\abc\\file.tx?t?Hell$o";
//         string sents = Amount = 5000;
//         string pat = @"Amount = (?<value>\d\d+)";

//         //Console.Write("Match: " + m.Value);
//         Pat = @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})-";
//         input = "1992-02-23";
//         Match m = Regex.Match(sents, input);
//         Console.WriteLine(m.Groups['year'].Value);
//         Console.WriteLine(m.Groups['month'].Value);
//         Console.WriteLine("------------");
//     }
// }
// public class RegexMatches
// {
//     public static void ress()
//     {
//         //string sents = "?10A20B30C!@_abc _0!\t";
//         string sents = "HelloC:\\abc\\file.tx?t?Hello$";
//         string pat = @"^H";
//         Pat = @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})-";
//         input = "1992-02-23";
//         MatchCollection m = Regex.Matches(sents, input);
//         Console.WriteLine(m.Groups['year'].Value);
//         Console.WriteLine(m.Groups['month'].Value);
//         Console.WriteLine("Matches");
//         foreach (var v in m)
//         {
//            Console.Write(v); 
//         }
        
//     }
// }
