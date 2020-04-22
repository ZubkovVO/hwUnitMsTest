using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class SinTest
    {
        [TestMethod]
        public void Sin_45_positive()
        {
            //arrange
            double x = 45;
            double expected = 0.85090352453;
            double delta = 0.00000000001;

            //act
            Calculator c = new Calculator();
            double actual = c.Sin(x);

            //assert
            Assert.AreEqual(expected, actual, delta);
        }
    }
}
