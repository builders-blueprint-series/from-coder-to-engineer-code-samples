﻿namespace FromCoderToEngineer.Samples.Chapter2.ManyImplementations
{
    public class GoldCustomerUpdated : EliteCustomerUpdated
    {
        // More overrides for Gold elites.

        public override decimal ApplyDiscount(decimal amount, bool isEligible)
        {
            if (isEligible)
            {
                return amount * .80m;
            }

            return amount;
        }
    }
}
