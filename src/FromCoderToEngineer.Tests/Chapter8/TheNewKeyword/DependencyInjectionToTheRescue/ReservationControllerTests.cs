namespace FromCoderToEngineer.Tests.Chapter8.TheNewKeyword.DependencyInjectionToTheRescue
{
    using System;
    using System.Collections.Generic;
    using FromCoderToEngineer.Samples.Chapter8.TheNewKeyword.DependencyInjectionToTheRescue;
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
        public void GetAllReservations_Success_ReturnsOk()
        {
            _mockService.Setup(x => x.FindAllReservations())
                .Returns(new List<Reservation>());

            var result = _reservationController.GetAllReservations();

            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void GetAllReservations_Exception_ReturnsInternalServerError()
        {
            _mockService.Setup(x => x.FindAllReservations())
                .Throws(new Exception());

            var result = _reservationController.GetAllReservations() as ObjectResult;

            Assert.AreEqual(StatusCodes.Status500InternalServerError, result.StatusCode);
        }
    }
}
