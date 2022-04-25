using FromCoderToEngineer.Samples.Chapter1.PublicSetters;

namespace FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections
{
    public class Name
    {
        public Name(string firstName, string lastName, string middleName, string preferredName, Honorifics honorifics = Honorifics.None, Suffix suffix = Suffix.None)
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

        public string MiddleName { get; }

        public string LastName { get; }

        public string PreferredName { get; }

        public Honorifics Honorifics { get; }

        public Suffix Suffix { get; }
    }
}