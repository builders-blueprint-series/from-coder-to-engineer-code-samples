using FromCoderToEngineer.Samples.Chapter1.PublicSetters;

namespace FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections
{
    public class Customer
    {
        // Certain properties omitted for brevity

        public Customer(string firstName, string lastName)
        {
            Validator.ValidNameFormat(firstName);
            Validator.ValidNameFormat(lastName);

            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; }
    }
}