using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class InvalidPhoneNumberException : Exception
{
    public InvalidPhoneNumberException(string msg) : base(msg) { }
}
public class UserVerification
{
    public string UserName{get; set;}
    public string PhoneNumber{get; set;}
    public UserVerification(string name, string num)
    {
        UserName = name;
        PhoneNumber = num;
    }
    public UserVerification ValidatePhone()
    {
        if(PhoneNumber.Length != 10)
        {
            throw new InvalidPhoneNumberException("Phone number should be exact 10 digits");
        }
        return this;
    }
}
