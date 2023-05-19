using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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