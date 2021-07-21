namespace FromCoderToEngineer.Tests.Chapter8.TheNewKeyword.NewForServices
{
    using FromCoderToEngineer.Samples.Chapter8.TheNewKeyword.NewForServices;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ReservationControllerTests
    {
        private readonly ReservationController _reservationController;

        public ReservationControllerTests()
        {
            _reservationController = new ReservationController();
        }

        [TestMethod]
        public void GetAllReservations_Success_ReturnsOk()
        {
            var result = _reservationController.GetAllReservations();

            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void GetAllReservations_Exception_ReturnsInternalServerError()
        {
            var result = _reservationController.GetAllReservations() as ObjectResult;

            Assert.AreEqual(StatusCodes.Status500InternalServerError, result.StatusCode);
        }
    }
}
