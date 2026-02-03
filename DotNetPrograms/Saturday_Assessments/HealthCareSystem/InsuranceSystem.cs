public class InsuranceService
{
    public double ApplyCoverage(double billAmount, int coveragePercent)
    {
        if (billAmount <= 0)
            throw new Exception("Bill amount must be greater than zero");

        if (coveragePercent < 0 || coveragePercent > 100)
            throw new Exception("Coverage percent must be between 0 and 100");

        double discount = (billAmount * coveragePercent) / 100.0;
        double finalAmount = billAmount - discount;
        return finalAmount;
    }
    public bool IsEligible(double billAmount, int coveragePercent)
    {
        return billAmount > 1000 && coveragePercent > 0;
    }
    public void PrintInsuranceSummary(double billAmount, int coveragePercent)
    {
        double discount = (billAmount * coveragePercent) / 100.0;
        double payable = billAmount - discount;

        Console.WriteLine("---------------------------------");
        Console.WriteLine("        INSURANCE SUMMARY");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Original Bill: " + billAmount);
        Console.WriteLine("Coverage (%): " + coveragePercent);
        Console.WriteLine("Insurance Covered Amount: " + discount);
        Console.WriteLine("Final Payable: " + payable);
        Console.WriteLine("---------------------------------");
    }
}
