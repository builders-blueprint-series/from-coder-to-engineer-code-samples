using FromCoderToEngineer.Samples.Chapter2.ManyImplementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FromCoderToEngineer.Tests.Chapter2.ManyImplementations
{
    [TestClass]
    public class GoldCanIgnoreEligibilityTests
    {
        [TestMethod]
        public void ApplyDiscount_Eligible_IsCorrect()
        {
            var customer = new GoldCanIgnoreEligibility();

            var result = customer.ApplyDiscount(100m, true);

            Assert.AreEqual(80m, result);
        }

        [TestMethod]
        public void ApplyDiscount_InEligible_IsCorrect()
        {
            var customer = new GoldCanIgnoreEligibility();

            var result = customer.ApplyDiscount(100m, false);

            // This will fail even though we tell the method not to apply the discount.
            Assert.AreEqual(100m, result);
        }
    }
}
