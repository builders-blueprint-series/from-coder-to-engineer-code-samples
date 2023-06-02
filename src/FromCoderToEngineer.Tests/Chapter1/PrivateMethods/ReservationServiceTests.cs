using FromCoderToEngineer.Samples.Chapter1.PrivateMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FromCoderToEngineer.Tests.Chapter1.PrivateMethods
{
    [TestClass]
    public class ReservationServiceTests
    {
        [TestMethod]
        public void AvailabilityMatchesCustomer_DateTimeMatchesRange_ReturnsTrue()
        {
            var service = new ReservationService();

            // Does not compile, inaccessible due to protection level.
            //var result = service.AvailabilityMatchesCustomer(DateTime.UtcNow, DateTime.MinValue, DateTime.MaxValue);

            //Assert.IsTrue(result);
        }
    }
}