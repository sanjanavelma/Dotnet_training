using System;
using System.Text.RegularExpressions;

public class RegexMatches
{
    public static void ress()
    {
        string input = "1992-02-23";
        string pat = @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";

        MatchCollection m = Regex.Matches(input, pat);
        Match matching = Regex.Match(input, pat);
        foreach(Match mes in m)
        {
            Console.WriteLine("Year:  " + mes.Groups[0].Value);
            Console.WriteLine("Month: " + mes.Groups[1].Value);
            Console.WriteLine("Date:  " + mes.Groups[2].Value);
        }

    }
}
public class RegexMatch
{
    public static void res()
    {
        string sents = "Amount = 5000";
        string pat = @"Amount\s*=\s*(?<value>\d+)";

        Match m = Regex.Match(sents, pat);
        Console.WriteLine("Amount: " + m.Groups["value"].Value);

    }
}
