using System;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters
{
    internal class ExposedPublicApi
    {
        public Customer ICanDoAnything(Customer customer)
        {
            customer.Id = Guid.NewGuid();
            customer.FirstName = "RazzleDazzle";

            return customer;
        }
    }
}