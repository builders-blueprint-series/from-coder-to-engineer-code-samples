using FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections;

namespace FromCoderToEngineer.Samples.Chapter1.PublicSetters
{
    internal class EmailValidator
    {
        public void Validate(Email email)
        {
            Validator.ValidEmail(email.Value);
        }
    }
}