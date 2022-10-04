using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testy
{
    [TestClass]
    public class CalculatorMSTests
    {
        [TestMethod]
        public void AddTwoIntegers_ReturnInteger()
        {
            Calculator calculator = new();
            int expectedResult = 3;
            int result = calculator.AddNumbers(1, 2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CheckIfNumberIsOdd_InputEven_ReturnFalse()
        {
            Calculator calculator = new();
            bool isOdd = calculator.IsOddNumber(4);
            Assert.IsFalse(isOdd);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(3213)]
        [DataRow(3431)]
        public void CheckIfNumberIsOdd_InputOdd_ReturnTrue(int input)
        {
            Calculator calculator = new();
            bool isOdd = calculator.IsOddNumber(input);
            Assert.IsTrue(isOdd);
        }

        [TestMethod]
        [DataRow(1, true)]
        [DataRow(313, true)]
        [DataRow(34, false)]
        [DataRow(3764, false)]
        public void CheckIfNumberIsOdd_InputOddAndEven_ReturnTrueAndFalse(int input, bool expectedResult)
        {
            Calculator calculator = new();
            bool result = calculator.IsOddNumber(input);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(5.4, 10.5)]
        [DataRow(5.43, 10.53)]
        [DataRow(5.49, 10.59)]
        public void AddTwoDoubles_ReturnDouble(double a, double b)
        {
            Calculator calculator = new();
            double expectedResult = 15.9;
            double result = calculator.AddNumbersDouble(a, b);
            Assert.AreEqual(expectedResult, result, 0.2);
        }
    }
}
