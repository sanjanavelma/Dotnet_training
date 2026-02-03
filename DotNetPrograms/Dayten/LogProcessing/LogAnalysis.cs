using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace LogProcessing
{
    public class LogParser
    {
        private readonly string validLineRegexPattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
        private readonly string splitLineRegexPattern = @"<(?:\*+|=+|\^\*)>";
        private readonly string quotedPasswordRegexPattern = @"(?i)""[^""]*password[^""]*""";
        private readonly string endOfLineRegexPattern = @"\s*end-of-line\d+$";
        private readonly string weakPasswordRegexPattern = @"(?i)password\w+";
        //---------------TASK 1----------------//
        public bool IsValidLine(string text)
        {
            return Regex.IsMatch(text, validLineRegexPattern);
        }
        //---------------TASK 2----------------//
        public string[] SplitLogLine(string text)
        {
            return Regex.Split(text, splitLineRegexPattern);
        }
        //---------------TASK 3----------------//
        public int CountQuotedPasswords(string lines)
        {
            return Regex.Matches(lines, quotedPasswordRegexPattern).Count;
        }
        //---------------TASK 4----------------//
        public string RemoveEndOfLineText(string line)
        {
            return Regex.Replace(line, endOfLineRegexPattern, "");
        }
        //---------------TASK 5----------------//
        public string[] ListLinesWithPasswords(string[] lines)
        {
            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                Match m = Regex.Match(lines[i], weakPasswordRegexPattern);

                if (m.Value != "")
                    result[i] = $"{m.Value}: {lines[i]}";
                else
                    result[i] = $"--------: {lines[i]}";
            }

            return result;
        }
    }
}