using FromCoderToEngineer.Samples.Chapter1.PublicSetters._1;
using System;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters._2
{
    internal class PublicSetters
    {
        public void AnythingCanHappen()
        {
            var customer = new Customer
            {
                Id = Guid.Empty,
                FirstName = "Jimbo123",
                LastName = null,
                Email = "notValid@spam",
            };
        }
    }
}