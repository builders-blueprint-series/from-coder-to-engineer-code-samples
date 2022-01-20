﻿using FromCoderToEngineer.Samples.Chapter7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FromCoderToEngineer.Tests.Chapter7
{
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