namespace FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections
{
    public class CustomerWithEncapsulatedObjects
    {
        public CustomerWithEncapsulatedObjects(Name name, Email email, AvailabilityRange availabilityRange)
        {
            Name = name;
            Email = email;
            AvailabilityRange = availabilityRange;
        }

        public Name Name { get; }

        public Email Email { get; }

        public AvailabilityRange AvailabilityRange { get; }
    }
}
