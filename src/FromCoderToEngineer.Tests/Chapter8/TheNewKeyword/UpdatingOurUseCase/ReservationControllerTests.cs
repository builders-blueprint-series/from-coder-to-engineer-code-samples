namespace FromCoderToEngineer.Tests.Chapter8.TheNewKeyword.UpdatingOurUseCase
{
    using System;
    using FromCoderToEngineer.Samples.Chapter8.TheNewKeyword.UpdatingOurUseCase;
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
        public void FindAllReservationsOnDate_DefaultMaxDateTime_ReturnsBadRequest()
        {
            var result = _reservationController.FindAllReservationsOnDate(DateTime.Now, DateTime.MinValue);

            Assert.IsInstanceOfType(result, typeof(BadRequestResult));
        }
    }
}
