using System;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters
{
    public class FullyEncapsulatedCustomer
    {
        public FullyEncapsulatedCustomer(string firstName, string lastName, string email)
        {
            Validator.ValidNameFormat(firstName);
            Validator.ValidNameFormat(lastName);
            Validator.ValidEmail(email);

            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Guid Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string Email { get; }
    }
}