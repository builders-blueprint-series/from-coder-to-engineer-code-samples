using FromCoderToEngineer.Samples.Chapter1.PublicSetters;

namespace FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections
{
    public class CustomerWithComplexName
    {
        public CustomerWithComplexName(string firstName, string lastName, string middleName, string preferredName, Honorifics honorifics, Suffix suffix)
        {
            Validator.ValidNameFormat(firstName);
            Validator.ValidNameFormat(lastName);
            Validator.ValidNameFormat(middleName);
            Validator.ValidNameFormat(preferredName);

            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            PreferredName = preferredName;
            Honorifics = honorifics;
            Suffix = suffix;
        }

        public string FirstName { get; }

        public string MiddleName { get; set; }

        public string LastName { get; }

        public string PreferredName { get; set; }

        public Honorifics Honorifics { get; set; }

        public Suffix Suffix { get; set; }
    }
}