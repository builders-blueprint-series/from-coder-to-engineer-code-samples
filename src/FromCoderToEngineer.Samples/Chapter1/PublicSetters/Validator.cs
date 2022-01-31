using System;
using System.Text.RegularExpressions;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters
{
    public static class Validator
    {
        public static void StringIsNotEmptyOrNull(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }
        }

        public static void ValidNameFormat(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Name is not match the required pattern.", nameof(name));
            }
        }

        public static void ValidEmail(string email)
        {
            if (!Regex.IsMatch(email, @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b"))
            {
                throw new ArgumentException("Email is not in a valid format.", nameof(email));
            }
        }
    }
}