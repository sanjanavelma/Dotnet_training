using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Member
{
    public string MemberName{get; set;}
    public int Age{get; set;}
    public double Height{get; set;}
    public double Weight{get; set;}
    public string Goal{get; set;} 
    public Member(string name, int age, double h, double w, string goal)
    {
        MemberName = name;
        Age = age;
        Height = h;
        Weight = w;
        Goal = goal;
    } 
    public double CalculateBMI()
    {
        double IBM = Weight/(Height * Height);
        return IBM;
    }
    public double CalculateFee()
    {
        double fee;
        double BMI = CalculateBMI();
        if(Goal == "WeightLoss" && BMI >= 25)
        {
            fee = 5000;
        }
        else if(Goal == "Fitness" && BMI >= 18.5 && BMI <= 24.9)
        {
            fee = 4000;
        }
        else if(Goal == "Therapy")
        {
            fee = 6000;
        }
        else
        {
            fee = 4500;
        }
        return fee;
    }
}
public class YogaCenter
{
    public static List<Member> Members = new List<Member>();
    public void AddMember(Member m)
    {
        Members.Add(m);
    }
    public void DisplayMembers()
    {
        foreach(var m in Members)
        {
            double bmi = m.CalculateBMI();
            double fee = m.CalculateFee();
            Console.WriteLine($"{m.MemberName} | {bmi:F2} | {fee}");
        }
    }
}