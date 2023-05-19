using FromCoderToEngineer.Samples.Chapter1.PublicSetters;

namespace FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections
{
    public class NameValidator
    {
        public void Validate(Name name)
        {
            Validator.ValidNameFormat(name.FirstName);
            Validator.ValidNameFormat(name.LastName);
            Validator.ValidNameFormat(name.MiddleName);
            Validator.ValidNameFormat(name.PreferredName);

            // Probably more Validators down here.
        }
    }
}