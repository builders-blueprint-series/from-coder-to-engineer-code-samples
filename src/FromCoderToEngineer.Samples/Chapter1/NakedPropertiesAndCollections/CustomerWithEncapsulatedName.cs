namespace FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections
{
    public class CustomerWithEncapsulatedName
    {
        public CustomerWithEncapsulatedName(Name name)
        {
            Name = name;
        }

        public Name Name { get; }
    }
}