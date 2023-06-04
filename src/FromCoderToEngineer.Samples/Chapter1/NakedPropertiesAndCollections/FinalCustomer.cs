namespace FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections
{
    public class FinalCustomer
    {
        public FinalCustomer(Name name, Email email, AvailabilityRange availabilityRange)
        {
            Name = name;
            Email = email;
            AvailabilityRange = availabilityRange;

            new CustomerValidator().Validate(name, email);
        }

        public Name Name { get; }

        public Email Email { get; }

        public AvailabilityRange AvailabilityRange { get; }
    }
}
