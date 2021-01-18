namespace FromCoderToEngineer.Tests.Chapter7
{
    using System;
    using FromCoderToEngineer.Samples.Chapter7;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void MaskId_ReturnsCorrectValue()
        {
            var id = Guid.Parse("4dd48f87-be33-4d31-bc2e-4888ef8aaaee");

            var customer = new Customer(id);

            Assert.AreEqual("4dd48f87", customer.MaskedId());
        }
    }
}
