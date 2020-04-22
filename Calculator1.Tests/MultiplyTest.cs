using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class MultiplyTest
    {
        [TestMethod]
        public void Mult_5and5_25returned()
        {
            //arrange
            double x = 5;
            double y = 5;
            double expected = 25;

            //act
            Calculator c = new Calculator();
            double actual = c.Multiply(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
