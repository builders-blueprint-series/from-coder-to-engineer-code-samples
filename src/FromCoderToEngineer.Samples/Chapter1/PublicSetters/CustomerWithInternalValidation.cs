using System;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters
{
    public class CustomerWithInternalValidation
    {
        public CustomerWithInternalValidation(string firstName, string lastName, string email)
        {
            if (firstName != null && lastName != null && email != null)
            {
                Id = Guid.NewGuid();
                FirstName = firstName;
                LastName = lastName;
                Email = email;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public Guid Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string Email { get; }
    }
}