using FromCoderToEngineer.Samples.Chapter2.ManyImplementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FromCoderToEngineer.Tests.Chapter2.ManyImplementations
{
    [TestClass]
    public class EliteCustomerUpdatedTests
    {
        [TestMethod]
        public void ApplyDiscount_Eligible_IsCorrect()
        {
            var customer = new EliteCustomerUpdated();

            var result = customer.ApplyDiscount(100m, true);

            Assert.AreEqual(90m, result);
        }

        [TestMethod]
        public void ApplyDiscount_InEligible_IsCorrect()
        {
            var customer = new EliteCustomerUpdated();

            var result = customer.ApplyDiscount(100m, false);

            Assert.AreEqual(100m, result);
        }
    }
}
