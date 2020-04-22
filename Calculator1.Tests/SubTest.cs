using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class SubTest
    {

        [TestMethod]
        public void Sub_15from30_15returned()
        {
            //arrange
            double x = 30;
            double y = 15;
            double expected = 15;

            //act
            Calculator c = new Calculator();
            double actual = c.Sub(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
