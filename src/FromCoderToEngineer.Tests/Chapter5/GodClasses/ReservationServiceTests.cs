using FromCoderToEngineer.Samples.Chapter5.Common;
using FromCoderToEngineer.Samples.Chapter5.GodClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace FromCoderToEngineer.Tests.Chapter5.GodClasses
{
    [TestClass]
    public class ReservationServiceTests
    {
        private readonly Mock<ISmtpClient> _smptClient;
        private readonly Mock<ICustomerRepository> _customerRepository;
        private readonly Mock<IReservationRepository> _reservationRepository;
        private readonly IReservationService _service;

        public ReservationServiceTests()
        {
            _smptClient = new Mock<ISmtpClient>();
            _customerRepository = new Mock<ICustomerRepository>();
            _reservationRepository = new Mock<IReservationRepository>();
            _service = new ReservationService(_smptClient.Object, _customerRepository.Object, _reservationRepository.Object);
        }

        [TestMethod]
        public void CreateReservation_Success_CallsSmtpClient()
        {
            _reservationRepository.Setup(x => x.AddReservation(It.IsAny<Reservation>()))
                .Returns(true);

            _customerRepository.Setup(x => x.FindById(It.IsAny<Guid>()))
                .Returns(new Customer());

            var result = _service.CreateReservation(new CreateReservationRequest());

            _smptClient.Verify(x => x.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public void CreateReservation_Failure_DoesNotCallSmtpClient()
        {
            _reservationRepository.Setup(x => x.AddReservation(It.IsAny<Reservation>()))
                .Returns(false);

            _customerRepository.Setup(x => x.FindById(It.IsAny<Guid>()))
                .Returns(new Customer());

            var result = _service.CreateReservation(new CreateReservationRequest());

            _smptClient.Verify(x => x.SendEmail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        }
    }
}
