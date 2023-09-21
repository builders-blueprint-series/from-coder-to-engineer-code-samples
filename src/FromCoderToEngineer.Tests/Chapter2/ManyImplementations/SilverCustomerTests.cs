﻿using FromCoderToEngineer.Samples.Chapter2.ManyImplementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FromCoderToEngineer.Tests.Chapter2.ManyImplementations
{
    [TestClass]
    public class SilverCustomerTests
    {
        [TestMethod]
        public void ApplyDiscount_IsCorrect()
        {
            var customer = new SilverCustomer();

            var result = customer.ApplyDiscount(100m);

            Assert.AreEqual(85m, result);
        }
    }
}
