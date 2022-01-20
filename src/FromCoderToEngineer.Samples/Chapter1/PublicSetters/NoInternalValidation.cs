using System;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters
{
    internal class NoInternalValidation
    {
        public void HaveToValidateOutsideCustomer(string first, string last, string email)
        {
            if (first != null && last != null && email != null)
            {
                var customer = new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName = first,
                    LastName = last,
                    Email = email,
                };
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}