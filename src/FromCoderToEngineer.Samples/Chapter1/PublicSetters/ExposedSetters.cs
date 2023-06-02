using System;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters
{
    internal class ExposedSetters
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