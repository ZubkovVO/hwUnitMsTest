using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class AddTest
    {

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(12, 30, 42)]
        [DataRow(14, 1, 15)]
        public void Add_test(double x, double y, double expected)
        {
            //arrange

            //act
            Calculator c = new Calculator();
            double result = c.Add(x, y);

            //assert
            Assert.AreEqual(expected, result);

        }
    }
}
