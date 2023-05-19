using FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FromCoderToEngineer.Tests.Chapter1.NakedPropertiesAndCollections
{
    [TestClass]
    public class CustomerWithComplexNameTests
    {
        [TestMethod]
        public void CustomerWithComplexName_IsInCorrectState()
        {
            var customer = new CustomerWithComplexName("Bob", "Bobber", "Bobbert", "Bobby", Honorifics.Esq, Suffix.PhD);

            // Our customer class is still missing Email and available DateTimes from earlier.
        }
    }
}