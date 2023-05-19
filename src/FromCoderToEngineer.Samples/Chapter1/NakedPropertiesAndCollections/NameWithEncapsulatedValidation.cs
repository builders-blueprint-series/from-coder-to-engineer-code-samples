using FromCoderToEngineer.Samples.Chapter1.PublicSetters;

namespace FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections
{
    public class NameWithEncapsulatedValidation
    {
        public NameWithEncapsulatedValidation(string firstName, string lastName, string middleName, string preferredName, Honorifics honorifics = Honorifics.None, Suffix suffix = Suffix.None)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            PreferredName = preferredName;
            Honorifics = honorifics;
            Suffix = suffix;

            new NameValidator().Validate(this);
        }

        public string FirstName { get; }

        public string MiddleName { get; }

        public string LastName { get; }

        public string PreferredName { get; }

        public Honorifics Honorifics { get; }

        public Suffix Suffix { get; }
    }
}
