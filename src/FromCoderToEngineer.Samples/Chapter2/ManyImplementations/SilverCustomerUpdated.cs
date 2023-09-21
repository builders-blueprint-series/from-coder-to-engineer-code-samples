namespace FromCoderToEngineer.Samples.Chapter2.ManyImplementations
{
    public class SilverCustomerUpdated : EliteCustomerUpdated
    {
        public override decimal ApplyDiscount(decimal amount, bool isEligible)
        {
            if (isEligible)
            {
                return amount * .85m;
            }

            return amount;
        }
    }
}
