using FromCoderToEngineer.Samples.Chapter7;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FromCoderToEngineer.Tests.Chapter7
{
    [TestClass]
    public class IdMaskerTests
    {
        [TestMethod]
        public void MaskId_Guid_ReturnsCorrectValue()
        {
            var id = Guid.Parse("4dd48f87-be33-4d31-bc2e-4888ef8aaaee");

            Assert.AreEqual("4dd48f87", IdMasker.MaskId(id));
        }

        [TestMethod]
        public void MaskId_Object_ReturnsCorrectValue()
        {
            const string id = "4dd48f87-be33-4d31-bc2e-4888ef8aaaee";

            Assert.AreEqual("4dd48f87", IdMasker.MaskId(id));
        }

        [TestMethod]
        public void MaskId_Null_ThrowsException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => IdMasker.MaskId(null));
        }
    }
}