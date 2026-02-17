using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class PasswordMismatchException : Exception
{
    public PasswordMismatchException(string msg) : base(msg) { }
}
public class UserAuthentication
{
    public string UserName{get; set;}
    public string Password{get; set;}
    public string ConfirmPassword{get; set;}
    public UserAuthentication(string name, string pass, string conpass)
    {
        UserName = name;
        Password = pass;
        ConfirmPassword = conpass;
    }
    public void ValidatePassword()
    {
        if(Password != ConfirmPassword)
        {
            throw new PasswordMismatchException("Password doesn't match");
        }
        else
        {
            Console.WriteLine("User authenticated successfully");
        }
    }
}
