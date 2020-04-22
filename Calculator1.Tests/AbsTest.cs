using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class AbsTest
    {
        [TestMethod]
        public void Abs_10positive_10returned()
        {
            //arrange
            double x = 10;
            double expected = 10;

            //act
            Calculator c = new Calculator();
            double actual = c.Abs(x);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Abs_10negative_10returned()
        {
            //arrange
            double x = -10;
            double expected = 10;

            //act
            Calculator c = new Calculator();
            double actual = c.Abs(x);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
