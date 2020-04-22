using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator1.Tests
{
    [TestClass]
    public class AddTest
    {

        //public TestContext TestContext{ get; set; }

        /*[DataSource("Microsoft.VisualStduio.TestTools.DataSource.XML",
            "testData.xml",
            "Equation",
            DataAccessMethod.Sequential)]*/

        [TestMethod]
        public void Add_10and20_30returned()
        {
            //arrange
            double x = 10;
            double y = 20;
            double expected = 30;

            //act
            Calculator c = new Calculator();
            double actual = c.Add(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
