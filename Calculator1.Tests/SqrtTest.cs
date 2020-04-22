using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class SqrtTest
    {
        [TestMethod]
        public void Sqrt_from16_4returned()
        {
            //arrange
            double x = 16;
            double expected = 4;

            //act
            Calculator c = new Calculator();
            double actual = c.Sqrt(x);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
