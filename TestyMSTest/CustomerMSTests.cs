using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Testy
{
    [TestClass]
    public class CustomerMSTests
    {
        private Customer customer;
        [TestInitialize]
        public void Setup()
        {
            customer = new Customer();
        }

        [TestMethod]
        public void CombineFirstNameLastName_ReturnFullName()
        {
            string fullName = customer.GreetAndCombineNames("John", "Walker");
            Assert.AreEqual("Hello, John Walker", fullName);
            StringAssert.Contains(fullName, ",");
            StringAssert.StartsWith(fullName, "Hello");
            StringAssert.EndsWith(fullName, "Walker");
            StringAssert.Matches(fullName, new Regex("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
        }

        [TestMethod]
        public void GreetMessage_NotGreeted_ReturnsNull()
        {
            Assert.IsNull(customer.GreetMessage);
        }
    }
}
