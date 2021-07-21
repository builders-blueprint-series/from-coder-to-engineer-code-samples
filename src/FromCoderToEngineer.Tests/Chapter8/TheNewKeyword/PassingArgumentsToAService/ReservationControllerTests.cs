namespace FromCoderToEngineer.Tests.Chapter8.TheNewKeyword.PassingArgumentsToAService
{
    using System;
    using System.Collections.Generic;
    using FromCoderToEngineer.Samples.Chapter8.TheNewKeyword.PassingArgumentsToAService;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Samples.Common;

    [TestClass]
    public class ReservationControllerTests
    {
        private readonly Mock<IReservationService> _mockService;
        private readonly ReservationController _reservationController;

        public ReservationControllerTests()
        {
            _mockService = new Mock<IReservationService>();
            _reservationController = new ReservationController(_mockService.Object);
        }

        [TestMethod]
        public void FindAllReservationsOnDate_DefaultDate_ReturnsBadRequest()
        {
            var result = _reservationController.FindAllReservationsOnDate(DateTime.MinValue);

            Assert.IsInstanceOfType(result, typeof(BadRequestResult));
        }

        [TestMethod]
        public void FindAllReservationsOnDate_Success_ReturnsOk()
        {
            _mockService.Setup(x => x.FindAllReservationsOnDate(It.IsAny<DateTime>()))
                .Returns(new List<Reservation>());

            var result = _reservationController.FindAllReservationsOnDate(DateTime.Now);

            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void FindAllReservationsOnDate_Exception_ReturnsInternalServerError()
        {
            _mockService.Setup(x => x.FindAllReservationsOnDate(It.IsAny<DateTime>()))
                .Throws(new Exception());

            var result = _reservationController.FindAllReservationsOnDate(DateTime.Now) as ObjectResult;

            Assert.AreEqual(StatusCodes.Status500InternalServerError, result.StatusCode);
        }
    }
}
