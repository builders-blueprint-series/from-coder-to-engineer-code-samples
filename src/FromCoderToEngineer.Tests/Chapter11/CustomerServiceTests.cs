namespace FromCoderToEngineer.Tests.Chapter11
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FromCoderToEngineer.Samples.Chapter11;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class CustomerServiceTests
    {
        private readonly Mock<ICustomerRepository> _customerRepository;
        private readonly Mock<IEmailClient> _emailClient;
        private readonly ICustomerService _customerService;

        public CustomerServiceTests()
        {
            _customerRepository = new Mock<ICustomerRepository>();
            _emailClient = new Mock<IEmailClient>();
            _emailClient.Setup(x => x.SendNewStatusEmail(It.IsAny<Customer>()));
            _customerService = new CustomerService(_customerRepository.Object, _emailClient.Object);
        }

        [TestMethod]
        public void AddLoyaltyPoints_NewStatus_SendsEmail()
        {
            _customerRepository.Setup(x => x.GetById(It.IsAny<Guid>()))
                .Returns(new Customer());

            _customerService.AddLoyaltyPoints(Guid.NewGuid(), 25000);

            _emailClient.Verify(x => x.SendNewStatusEmail(It.IsAny<Customer>()), Times.Once);
        }

        [TestMethod]
        public void AddLoyaltyPoints_NoNewStatus_DoesNotSendEmail()
        {
            _customerRepository.Setup(x => x.GetById(It.IsAny<Guid>()))
                .Returns(new Customer());

            _customerService.AddLoyaltyPoints(Guid.NewGuid(), 15000);

            _emailClient.Verify(x => x.SendNewStatusEmail(It.IsAny<Customer>()), Times.Never);
        }

        [TestMethod]
        public void GiftPoints_SendsApology()
        {
            _customerRepository.Setup(x => x.GetById(It.IsAny<Guid>()))
                .Returns(new Customer());

            _customerService.GiftPoints(Guid.NewGuid(), 5000);

            _emailClient.Verify(x => x.SendApology(It.IsAny<Customer>()), Times.Once);
        }

        [TestMethod]
        public void CreateCustomer_ReturnsCorrectValues()
        {
            const string firstName = "John";
            const string lastName = "Doe";
            const string email = "john@doe.com";

            var result = _customerService.CreateCustomer(firstName, lastName, email);

            Assert.AreEqual(firstName, result.FirstName);
            Assert.AreEqual(lastName, result.LastName);
            Assert.AreEqual(email, result.Email);
        }

        [TestMethod]
        public void StatusMatchCustomer_ReturnsCorrectValues()
        {
            const string firstName = "John";
            const string lastName = "Doe";
            const string email = "john@doe.com";
            const LoyaltyStatus status = LoyaltyStatus.Gold;

            var result = _customerService.StatusMatchCustomer(firstName, lastName, email, status);

            Assert.AreEqual(firstName, result.FirstName);
            Assert.AreEqual(lastName, result.LastName);
            Assert.AreEqual(email, result.Email);
            Assert.AreEqual(status, result.Status);
        }

        [TestMethod]
        public void GetAllSilverCustomers_ReturnsCorrectCustomers()
        {
            _customerRepository.Setup(x => x.GetAllCustomers())
                .Returns(new List<Customer>
                {
                    new Customer { Status = LoyaltyStatus.Silver },
                    new Customer { Status = LoyaltyStatus.Blue },
                    new Customer { Status = LoyaltyStatus.Silver },
                    new Customer { Status = LoyaltyStatus.Gold },
                });

            var result = _customerService.GetAllSilverCustomers();

            Assert.IsTrue(result.All(x => x.Status == LoyaltyStatus.Silver));
        }
    }
}
