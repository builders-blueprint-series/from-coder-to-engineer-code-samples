using System;
using System.Text.RegularExpressions;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters
{
    internal class TooMuchCustomerValidationLogic
    {
        public TooMuchCustomerValidationLogic(string firstName, string lastName, string email)
        {
            if (firstName != null
                && firstName != string.Empty
                && lastName != null
                && lastName != string.Empty
                && email != null
                && email != string.Empty
                && Regex.IsMatch(firstName, @"^[a-zA-Z]+$")
                && Regex.IsMatch(lastName, @"^[a-zA-Z]+$")
                && Regex.IsMatch(email, @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b"))
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