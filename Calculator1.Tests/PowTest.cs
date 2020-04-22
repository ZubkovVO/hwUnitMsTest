using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class PowTest
    {
        [TestMethod]
        public void Pow_2and2_4returned()
        {
            //arrange
            double x = 2;
            double y = 2;
            double expected = 4;

            //act
            Calculator c = new Calculator();
            double actual = c.Pow(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
