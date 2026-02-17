using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class ConstructionEstimateException : Exception
{
    public ConstructionEstimateException(string msg) : base(msg) { }
}
public class ConstructionEstimate
{
       public double SiteArea{get; set;}
       public double ConstructionArea{get; set;}
       public double CostPerSquareUnit{get; set;}
       public ConstructionEstimate(double area, double Carea, double CSunit)
    {
        SiteArea = area;
        ConstructionArea = Carea;
        CostPerSquareUnit = CSunit;
    }
    public double ValidateAndEstimate()
    {
        double TotalCost;
        if(ConstructionArea > SiteArea)
        {
            throw new ConstructionEstimateException("Construction area is greater than site area");
        }
        else
        {
            TotalCost = ConstructionArea * CostPerSquareUnit;
        }
        return TotalCost;
    }
}
