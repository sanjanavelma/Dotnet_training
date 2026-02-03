using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Saturday_Assessments.HealthSyncBiling
{
    public abstract class Consultant
    {
        public string Id {get; set;}
        public string Name {get; set;}
        public double PayoutAmount {get; set;}
        public bool ValidateConsultantId()
        {
            if (string.IsNullOrWhiteSpace(Id))
            return false;

            Id = Id.Trim();

            return Id.Length == 6
            && Id.StartsWith("DR")
            && int.TryParse(Id.Substring(2), out _);
        }
        public abstract void CalculateGrossPayout();
        public virtual double GetTaxRate()
        {
            return (PayoutAmount > 5000) ? 0.15 : 0.05;
        }
        public void ApplyTax()
        {
            double tax = PayoutAmount * GetTaxRate();
            PayoutAmount -= tax;
        }
    }
    public class InHouse : Consultant
    {
        public double MonthlyStipend { get; set; }

        public override void CalculateGrossPayout()
        {
            double allowance = 0.20 * MonthlyStipend;
            double bonus = 0.10 * MonthlyStipend;
            PayoutAmount = MonthlyStipend + allowance + bonus;
        }
    } 
    public class Visiting : Consultant
    {
        public int ConsultationsCount { get; set; }
        public int RatePerVisit { get; set; }

        public override void CalculateGrossPayout()
        {
            PayoutAmount = ConsultationsCount * RatePerVisit;
        }

        public override double GetTaxRate()
        {
            return 0.10;
        }
    }
}