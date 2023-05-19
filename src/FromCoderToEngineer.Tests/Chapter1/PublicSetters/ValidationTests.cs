using FromCoderToEngineer.Samples.Chapter1.PublicSetters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FromCoderToEngineer.Tests.Chapter1.PublicSetters
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void StringIsNotEmptyOrNull_ValidObject_DoesNotThrowException()
        {
            Validator.StringIsNotEmptyOrNull("Valid");
        }

        [TestMethod]
        public void StringIsNotEmptyOrNull_InvalidObject_ThrowsException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Validator.StringIsNotEmptyOrNull(string.Empty));
        }

        [TestMethod]
        public void ValidNameFormat_ValidName_DoesNotThrowException()
        {
            Validator.ValidNameFormat("Billy");
        }

        [TestMethod]
        public void ValidNameFormat_InvalidName_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => Validator.ValidNameFormat("B1l)y"));
        }

        [TestMethod]
        public void ValidEmailFormat_ValidEmail_DoesNotThrowException()
        {
            Validator.ValidEmail("BILLY@BOB.COM");
        }

        [TestMethod]
        public void ValidEmailFormat_InvalidEmail_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() => Validator.ValidEmail("Billy.com@Bob"));
        }
    }
}