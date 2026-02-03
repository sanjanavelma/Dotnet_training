using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcUnitTesting.core;

namespace CalculatorTestProj;

[TestClass]
public class CalculatorTest
{
    [TestMethod]
    public void SumToN_ShouldReturnCorrectSum()
    {
        Calculator calc = new Calculator();
        int result = calc.SumToN(5);

        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void SumToN_ShouldFail_WhenInputIsZero()
    {
        Calculator calc = new Calculator();

        try
        {
            calc.SumToN(0);
            Assert.Fail("Exception was expected but not thrown");
        }
        catch (Exception)
        {
            Assert.IsTrue(true);
        }
    }
}
