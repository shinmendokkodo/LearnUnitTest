using NUnit.Framework;

namespace Testy
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddTwoIntegers_ReturnInteger()
        {
            Calculator calculator = new();
            int expectedResult = 3;
            int result = calculator.AddNumbers(1, 2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(5.4, 10.5)]
        [TestCase(5.43, 10.53)]
        [TestCase(5.49, 10.59)]
        public void AddTwoDoubles_ReturnDouble(double a, double b)
        {
            Calculator calculator = new();
            double expectedResult = 15.9;
            double result = calculator.AddNumbersDouble(a, b);
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.2));
            /* Alternate way of double delta.
             * Assert.AreEqual(expectedResult, result, 0.2);
             */
        }

        [Test]
        public void CheckIfNumberIsOdd_InputEven_ReturnFalse()
        {
            Calculator calculator = new();
            bool isOdd = calculator.IsOddNumber(4);
            Assert.That(isOdd, Is.False);
        }

        /*
         * TestCaseAttribute serves the dual purpose 
         * of marking a method with parameters as a test method 
         * and providing inline data to be used when invoking that method.
         * 
         * TestCaseAttribute may appear one or more times on a test method, 
         * which may also carry other attributes providing test data.
         * 
         * TestCaseAttribute supports a number of additional named parameters:
         * Author - sets the author of the test.
         * Category - provides a comma-delimited list of categories for this test.
         * Description - sets the description property of the test.
         * ExcludePlatform - specifies a comma-delimited list of platforms on which the test should not run.
         * ExpectedResult - sets the expected result to be returned from the method, which must have a compatible return type.
         * Explicit - is set to true in order to make the individual test case Explicit. Use Reason to explain why.
         * Ignore - causes the test case to be ignored and specifies the reason.
         * IgnoreReason - causes this test case to be ignored and specifies the reason.
         * IncludePlatform - specifies a comma-delimited list of platforms on which the test should run.
         * Reason - specifies the reason for not running this test case. Use in conjunction with Explicit.
         * TestName - provides a name for the test. If not specified, a name is generated based on the method name and the arguments provided. See Template Based Test Naming.
         * TestOf - specifies the Type that this test is testing
         */
        [TestCase(11)]
        [TestCase(13)]
        public void CheckIfNumberIsOdd_InputOdd_ReturnTrue(int input)
        {
            Calculator calculator = new();
            bool isOdd = calculator.IsOddNumber(input);
            Assert.That(isOdd, Is.EqualTo(true));
            /*
             * Alternate way of doing assert is: 
             * Assert.IsTrue(isOdd);
             */
        }

        [TestCase(13, ExpectedResult = true)]
        [TestCase(16113, ExpectedResult = true)]
        [TestCase(14, ExpectedResult = false)]
        [TestCase(928, ExpectedResult = false)]
        public bool CheckIfNumberIsOdd_InputOddAndEven_ReturnTrueAndFalse(int input)
        {
            Calculator calculator = new();
            return calculator.IsOddNumber(input);
        }
    }
}
