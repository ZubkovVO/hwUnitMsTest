using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class isPositiveTest
    {
        [TestMethod]
        public void isPositive_12_true()
        {
            //arrange
            double x = 12;

            //act
            Calculator c = new Calculator();
            bool actual = c.isPositive(x);

            //assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void isPostive_minus12_false()
        {
            //arrange
            double x = -12;

            //act
            Calculator c = new Calculator();
            bool actual = c.isPositive(x);

            //assert
            Assert.IsFalse(actual);
        }
    }
}