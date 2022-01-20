using FromCoderToEngineer.Samples.Chapter8.BadDependencyInjectionPractices;
using FromCoderToEngineer.Samples.Chapter8.DependencyInversion;
using FromCoderToEngineer.Samples.Common.ReservationService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FromCoderToEngineer.Tests.Chapter8.DependencyInversion
{
    [TestClass]
    public class OverInjectingUnitTests
    {
        private readonly ICustomerService _customerService;

        public OverInjectingUnitTests()
        {
            var eventBus = new Mock<IEventBus>();
            // Setup eventBus mock.

            var systemClock = new Mock<ISystemClock>();
            // Setup systemClock mock.

            var reservationService = new Mock<IReservationService>();
            // Setup reservationService mock.

            var customerRepository = new Mock<ICustomerRepository>();
            // Setup customerRepository mock.

            _customerService = new OverInjecting(eventBus.Object, systemClock.Object, reservationService.Object, customerRepository.Object, new CustomerFactory());
        }

        [TestMethod]
        public void Handle_DoesSomethingWeExpectToHappen()
        {
            // Unit testing code.
        }
    }
}