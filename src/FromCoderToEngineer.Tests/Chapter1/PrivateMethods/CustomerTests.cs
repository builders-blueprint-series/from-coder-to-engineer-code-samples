using FromCoderToEngineer.Samples.Chapter1.PrivateMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FromCoderToEngineer.Tests.Chapter1.PrivateMethods
{
    [TestClass]
    public class CustomerTests
    {
        private readonly CustomerWithPrivateValues _customer;

        public CustomerTests()
        {
            var min = new DateTime(2000, 1, 1, 18, 0, 0);
            var max = new DateTime(2000, 1, 1, 19, 0, 0);
            _customer = new CustomerWithPrivateValues(min, max);
        }

        [TestMethod]
        public void AvailabilityMatchesCustomer_OutOfRange_ReturnsFalse()
        {
            var availability = new DateTime(2000, 1, 1, 17, 45, 0);

            var result = _customer.AvailabilityMatchesCustomer(availability);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AvailabilityMatchesCustomer_InRange_ReturnsTrue()
        {
            var availability = new DateTime(2000, 1, 1, 18, 30, 0);

            var result = _customer.AvailabilityMatchesCustomer(availability);

            Assert.IsTrue(result);
        }
    }
}