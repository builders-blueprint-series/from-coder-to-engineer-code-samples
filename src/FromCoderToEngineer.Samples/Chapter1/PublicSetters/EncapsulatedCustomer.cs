using System;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters
{
    public class EncapsulatedCustomer
    {
        public EncapsulatedCustomer(string firstName, string lastName, string email)
        {
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