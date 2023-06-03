using FromCoderToEngineer.Samples.Chapter1.NakedPropertiesAndCollections;

namespace FromCoderToEngineer.Samples.Chapter2.AddingToImplementations
{
    public class Customer
    {
        // Constructor and Properties

        public decimal ApplyDiscount(decimal total)
        {
            const decimal discount = .95m;

            return total * discount;
        }
    }
}
