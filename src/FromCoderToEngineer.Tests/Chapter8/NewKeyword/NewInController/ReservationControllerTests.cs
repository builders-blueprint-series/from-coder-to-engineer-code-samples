using FromCoderToEngineer.Samples.Chapter8.NewKeyword.NewInController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FromCoderToEngineer.Tests.Chapter8.NewKeyword.NewInController
{
    [TestClass]
    public class ReservationControllerTests
    {
        private ReservationController _reservationController;

        public ReservationControllerTests()
        {
            _reservationController = new ReservationController();
        }

        [TestMethod]
        public void GetAllReservation_OnSuccess_DoesNotThrowException()
        {
            // Our test code.
        }
    }
}
