using FromCoderToEngineer.Samples.Chapter1.PublicSetters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FromCoderToEngineer.Tests.Chapter1.PublicSetters
{
    [TestClass]
    public class TestingInternalCustomerValidation
    {
        [TestMethod]
        public void Customer_OnInitialization_HasCorrectProperties()
        {
            const string firstName = "Billy";
            const string lastName = "Bob";
            const string email = "Billy@Bob.com";

            var customer = new CustomerWithInternalValidation(firstName, lastName, email);

            Assert.AreEqual(firstName, customer.FirstName);
            Assert.AreEqual(lastName, customer.LastName);
            Assert.AreEqual(email, customer.Email);
        }

        [TestMethod]
        [DataRow("Billy", "Bob", null)]
        [DataRow("Billy", null, "Billy@Bob.com")]
        [DataRow(null, "Bob", "Billy@Bob.com")]
        public void Customer_OnNullInitialization_ThrowsException(string firstName, string lastName, string email)
        {
            Assert.ThrowsException<ArgumentNullException>(() => new CustomerWithInternalValidation(firstName, lastName, email));
        }
    }
}