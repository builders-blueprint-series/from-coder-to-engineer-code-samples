using FromCoderToEngineer.Samples.Common;

namespace FromCoderToEngineer.Samples.Chapter2.ManyImplementations
{
    public class EliteCustomer : Customer
    {
        // Properties and methods for Elite customers

        public virtual decimal ApplyDiscount(decimal amount)
        {
            return amount * .90m;
        }
    }
}
