using FromCoderToEngineer.Samples.Common;

namespace FromCoderToEngineer.Samples.Chapter2.ManyImplementations
{
    public class EliteCustomerUpdated : Customer
    {
        // Properties and methods for Elite customers

        public virtual decimal ApplyDiscount(decimal amount, bool isEligible)
        {
            if (isEligible)
            {
                return amount * .90m;
            }
            
            return amount;
        }
    }
}
