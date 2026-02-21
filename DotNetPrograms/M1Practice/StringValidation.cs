using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class StringValidation
{
    public static int Validate(string s)
    {
        if(!s.StartsWith("^[A-Za-z]"))
        {
            return 0;
        }
        if(!s.EndsWith("^[0-9]"))
        {
            return 0;
        }
        if(s.Length < 3)
        {
            return 0;
        }
        return 1;
    }
}
