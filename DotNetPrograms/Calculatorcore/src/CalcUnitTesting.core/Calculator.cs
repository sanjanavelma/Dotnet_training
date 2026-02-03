using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcUnitTesting.core
{
public class Calculator
{
    public int SumToN(int n)
    {
        if (n <= 0)
            throw new Exception("n must be greater than 0");

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }
}

}