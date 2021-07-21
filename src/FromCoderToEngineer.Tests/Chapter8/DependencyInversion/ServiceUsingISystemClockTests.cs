using FromCoderToEngineer.Samples.Chapter8.DealingWithConcreteOnlyClasses;
using FromCoderToEngineer.Samples.Chapter8.DependencyInversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace FromCoderToEngineer.Tests.Chapter8.DependencyInversion
{
    [TestClass]
    public class ServiceUsingISystemClockTests
    {
        private readonly ICustomerService _service;

        public ServiceUsingISystemClockTests()
        {
            var clock = new Mock<ISystemClock>();
            clock.Setup(x => x.Now()).Returns(new DateTime(2000, 1, 1));

            _service = new ServiceUsingISystemClock(clock.Object);
        }

        [TestMethod]
        public void Handle_ShouldThrowException()
        {
            var request = new ChangeCustomerReservationTime
            {
                DateTime = new DateTime(1999, 1, 1),
            };

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _service.Handle(request));
        }
    }
}
