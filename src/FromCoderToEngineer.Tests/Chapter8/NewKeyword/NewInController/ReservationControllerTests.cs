using FromCoderToEngineer.Samples.Chapter8.NewKeyword.NewInController;
using FromCoderToEngineer.Samples.Common.ReservationService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FromCoderToEngineer.Tests.Chapter8.NewKeyword.NewInController
{
    //[TestClass]
    //public class ReservationControllerTests
    //{
    //    private ReservationController _reservationController;

    //    public ReservationControllerTests()
    //    {
    //        _reservationController = new ReservationController();
    //    }

    //    [TestMethod]
    //    public void GetAllReservation_OnSuccess_DoesNotThrowException()
    //    {
    //        // Our test code.
    //    }
    //}

    [TestClass]
    public class ReservationControllerTests
    {
        private ReservationController _reservationController;

        public ReservationControllerTests()
        {
            var mockService = new Mock<IReservationService>();

            // Setup mock.

            _reservationController = new ReservationController(mockService.Object);
        }

        [TestMethod]
        public void GetAllReservation_OnSuccess_DoesNotThrowException()
        {
            // Our test code.
        }
    }
}