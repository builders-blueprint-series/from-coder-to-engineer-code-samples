using FromCoderToEngineer.Samples.Chapter1.PublicSetters;

namespace FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections
{
    internal class CustomerValidator
    {
        public void Validate(Name name, Email email)
        {
            new NameValidator().Validate(name);
            new EmailValidator() .Validate(email);
        }
    }
}
