using System;

public class DiagnosisService
{
    public int TotalEvaluations { get; private set; }
    public int LastTotalScore { get; private set; }
    public string Recommendation { get; private set; }

    public void Evaluate(in int age, ref string condition, out string riskLevel, params int[] testScores)
    {
        int sum = 0;
        foreach (int s in testScores)
            sum += s;

        LastTotalScore = sum;
        TotalEvaluations++;

        static bool IsCritical(int total)
        {
            return total > 250;
        }

        if (IsCritical(sum) || age > 60)
        {
            condition = "Serious";
            riskLevel = "High";
            Recommendation = "Immediate hospital admission recommended.";
        }
        else
        {
            riskLevel = "Moderate";
            Recommendation = "Regular monitoring and medication suggested.";
        }
    }

    public void PrintDiagnosisReport()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("        DIAGNOSIS REPORT");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Total Score: " + LastTotalScore);
        Console.WriteLine("Total Evaluations Done: " + TotalEvaluations);
        Console.WriteLine("Recommendation: " + Recommendation);
        Console.WriteLine("---------------------------------");
    }
}
