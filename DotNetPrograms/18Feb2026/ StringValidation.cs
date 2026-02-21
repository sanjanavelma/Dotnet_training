using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
public class StringValidation
{
    public static int Validate(string s)
    {
        // if(!char.IsLetter(s[0]))
        // {
        //     return 0;
        // }
        // if(!char.IsDigit(s[s.Length - 1]))
        // {
        //     return 0;
        // }
        // if(s.Length < 3)
        // {
        //     return 0;
        // }
        // return 1;
        return Regex.IsMatch(s, @"^[A-Za-z]\d$")? 1 : 0;
    }
}
