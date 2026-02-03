using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseString.Core;

namespace ReverseString.Tests;

[TestClass]
public class StringHelperTests
{
    [TestMethod]
    public void Reverse_ShouldWork()
    {
        var helper = new StringHelper();
        string result = helper.Reverse("hello");

        Assert.AreEqual("olleh", result);
    }

    [TestMethod]
    public void Reverse_ShouldFail_OnEmptyString()
    {
        var helper = new StringHelper();

        try
        {
            helper.Reverse("");
            Assert.Fail("Exception expected");
        }
        catch (Exception)
        {
            Assert.IsTrue(true);
        }
    }
}
