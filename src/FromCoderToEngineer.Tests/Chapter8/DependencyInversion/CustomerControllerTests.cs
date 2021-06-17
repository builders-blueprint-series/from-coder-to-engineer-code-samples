namespace FromCoderToEngineer.Samples.Chapter8.DependencyInversion
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class CustomerControllerTest
    {
        private readonly GoodCustomerController _controller;

        public CustomerControllerTest()
        {
            var customerService = new Mock<ICustomerService>();

            customerService.Setup(x => x.Handle(It.IsAny<ChangeCustomerReservationTime>()));

            _controller = new GoodCustomerController(customerService.Object);
        }

        [TestMethod]
        public void ChangeCustomerReservationTime_InvalidModel_ReturnsBadRequest()
        {
            // Implement unit test
        }
    }
}
