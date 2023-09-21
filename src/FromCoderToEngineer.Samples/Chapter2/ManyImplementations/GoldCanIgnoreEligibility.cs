namespace FromCoderToEngineer.Samples.Chapter2.ManyImplementations
{
    public class GoldCanIgnoreEligibility : EliteCustomerUpdated
    {
        // More overrides for Gold elites.

        public override decimal ApplyDiscount(decimal amount, bool isEligible)
        {
            return amount * .80m;
        }
    }
}
