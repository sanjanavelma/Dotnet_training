using System;
public class StayCalculator
{
    public int CalculateStayDays(int days)
    {
        if (days < 0)
            throw new Exception("Days cannot be negative");

        if (days == 0)
            return 0;

        return 1 + CalculateStayDays(days - 1);
    }
}
