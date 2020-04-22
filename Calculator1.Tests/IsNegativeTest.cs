using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class IsNegativeTest
    {
        [TestMethod]
        public void isNegative_minus10_true()
        {
            //arrange
            double x = -10;

            //act
            Calculator c = new Calculator();
            bool actual = c.isNegative(x);

            //assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void isNegative_10_false()
        {
            //arrange
            double x = 10;

            //act
            Calculator c = new Calculator();
            bool actual = c.isNegative(x);

            //assert
            Assert.IsFalse(actual);
        }
    }
}