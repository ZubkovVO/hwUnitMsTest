using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class SubTest
    {

        [DataTestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(10, 5, 5)]
        [DataRow(-10, -10, 0)]
        [DataRow(-10, 10, -20)]
        public void Sub_test(double x, double y, double expected)
        {
            //arrange


            //act
            Calculator c = new Calculator();
            double actual = c.Sub(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
