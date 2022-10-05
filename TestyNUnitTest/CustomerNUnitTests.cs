using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Testy
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer customer;

        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }
        [Test]
        public void CombineFirstNameLastName_ReturnFullName()
        {
            string fullName = customer.GreetAndCombineNames("John", "Walker");
            Assert.That(fullName, Is.EqualTo("Hello, John Walker"));
            Assert.That(fullName, Does.Contain(","));
            Assert.That(fullName, Does.StartWith("Hello"));
            Assert.That(fullName, Does.EndWith("Walker"));
            Assert.That(fullName, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnsNull()
        {
            Assert.That(customer.GreetMessage, Is.Null);
        }
    }
}
