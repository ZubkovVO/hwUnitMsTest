using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class CosTest
    {
        [TestMethod]
        public void Cos_45_positive()
        {
            //arrange
            double x = 45;
            double expected = 0.52532198881;
            double delta = 0.00000000001;

            //act
            Calculator c = new Calculator();
            double actual = c.Cos(x);

            //assert
            Assert.AreEqual(expected, actual, delta);
        }
    }
}
