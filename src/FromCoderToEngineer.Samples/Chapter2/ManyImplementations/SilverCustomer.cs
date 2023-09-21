namespace FromCoderToEngineer.Samples.Chapter2.ManyImplementations
{
    public class SilverCustomer : EliteCustomer
    {
        // More overrides for Silver elites.

        public override decimal ApplyDiscount(decimal amount)
        {
            return amount * .85m;
        }
    }
}
