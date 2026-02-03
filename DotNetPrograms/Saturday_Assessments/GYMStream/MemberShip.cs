using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saturday_Assessments.GYMStream
{
    public class InvalidTierException : Exception
    {
        public InvalidTierException(string message) : base(message) {}
    }
    public class MemberShip
    {
        public string Tier{get; set;}
        public int DurationInMonths{get; set;}
        public double BasePriceperMonth{get; set;}
        public bool ValidateEnrollment()
        {
            if (Tier != "Basic" && Tier != "Premium" && Tier != "Elite")
                {
                    throw new InvalidTierException("Tier not recognized. Please choose an available membership plan.");
                }
             if (DurationInMonths <= 0)
                {
                    throw new Exception("Duration must be at least one month.");
                }
            return true;
        }
        public double CalculateTotalBill()
        {
            double TotalPrice = DurationInMonths * BasePriceperMonth;
            double discountPercentage = 0;
            switch (Tier)
            {
                case "Basic":
                    discountPercentage = 2;
                    break;
                case "Premium":
                    discountPercentage = 7;
                    break;
                case "Elite":
                    discountPercentage = 12;
                    break;
            }
            double discountAmount = TotalPrice * (discountPercentage / 100);
            return TotalPrice - discountAmount;
        }
    }
}