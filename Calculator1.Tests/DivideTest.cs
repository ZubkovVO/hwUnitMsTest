using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class DivideTest
    {
        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(12, 12, 1)]
        [DataRow(-10, 2, -5)]
        public void Div_30per2_15returned(double x, double y, double expected)
        {
            //arrange

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
