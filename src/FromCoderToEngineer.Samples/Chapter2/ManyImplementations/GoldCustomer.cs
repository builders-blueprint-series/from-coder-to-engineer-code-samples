namespace FromCoderToEngineer.Samples.Chapter2.ManyImplementations
{
    public class GoldCustomer : EliteCustomer
    {
        // More overrides for Gold elites.

        public override decimal ApplyDiscount(decimal amount)
        {
            return amount * .80m;
        }
    }
}
