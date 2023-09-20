using System;
using System.Text.RegularExpressions;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters
{
    public class TooMuchCustomerValidationLogic
    {
        public TooMuchCustomerValidationLogic(string firstName, string lastName, string email)
        {
            if (!string.IsNullOrEmpty(firstName)
                && !string.IsNullOrEmpty(lastName)
                && !string.IsNullOrEmpty(email)
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