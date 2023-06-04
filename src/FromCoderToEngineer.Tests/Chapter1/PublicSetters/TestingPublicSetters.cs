using FromCoderToEngineer.Samples.Chapter1.PublicSetters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FromCoderToEngineer.Tests.Chapter1.PublicSetters
{
    [TestClass]
    public class TestingPublicSetters
    {
        [TestMethod]
        public void Customer_Is_In_Correct_State()
        {
            var customer = new Customer
            {
                FirstName = "UghOh,No1AlphaNumer1C",
                LastName = "Sp@CiAlCharactersNotGood",
                Email = "notValidEmail.com",

                // Forgot to assign Id
            };

            // A lot of Asserts down here.
        }
    }
}