using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters
{
    public class ClientsHaveToUseAConstructor
    {
        public void MakeANewCustomer(string firstName, string lastName, string email)
        {
            // Force clients to use a constructor.
            var customer = new EncapsulatedCustomer(firstName, lastName, email);

            // Will not compile.
            //var badCustomer = new EncapsulatedCustomer
            //{
            //    FirstName = firstName,
            //    LastName = lastName,
            //    Email = email,
            //    Id = Guid.NewGuid(),
            //};
        }
    }
}