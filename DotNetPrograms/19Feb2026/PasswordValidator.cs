using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public delegate bool PasswordRule(string password);
public class PasswordValidator
{
    private readonly List<PasswordRule> _rules = new();
    public void AddRule(PasswordRule rule)
    {
        _rules.Add(rule);
    }
    public bool Validate(string password)
    {
        foreach(var rule in _rules)
        {
            if(!rule(password))
            {
                return false;
            }
        }
        return true;
    }
}