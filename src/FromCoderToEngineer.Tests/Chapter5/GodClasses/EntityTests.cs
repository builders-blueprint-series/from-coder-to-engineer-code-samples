using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FromCoderToEngineer.Tests.Chapter5.GodClasses
{
    [TestClass]
    public class EntityTests
    {
        [TestMethod]
        public void AddNotification_NullNotification_ThrowsException()
        {
            var entity = new TestEntity();

            Assert.ThrowsException<NullReferenceException>(() => entity.AddNullNotification());
        }

        [TestMethod]
        public void AddNotification_IsInCollection()
        {
            var entity = new TestEntity();

            entity.AddNotification();

            Assert.AreEqual(1, entity.Notifications.Count);
        }
    }
}
