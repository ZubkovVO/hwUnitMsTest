using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class DivideTest
    {
        [TestMethod]
        public void Div_30per2_15returned()
        {
            //arrange
            double x = 30;
            double y = 2;
            double expected = 15;

            //act
            Calculator c = new Calculator();
            double actual = c.Divide(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //[ExpectedException(typeof(DivideByZeroException), "Divide by zero attempted")]
        public void Div_by0_excpetionReturned()
        {
            //arrange
            double x = 30;
            double y = 0;
            double expected = 15;

            //act
            Calculator c = new Calculator();
            double actual = c.Divide(x, y);

            //assert
            Assert.AreEqual(expected, actual);
            // Assert.ThrowsException<DivideByZeroException>(() => c.Divide(x, y));
        }
    }
}
