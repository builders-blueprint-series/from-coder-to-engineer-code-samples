using System;

namespace FromCoderToEngineer.Samples.Chapter2.AddingToImplementations
{
    public class CustomerWithEliteDiscount
    {
        private readonly EliteCustomerStatus _status;

        public CustomerWithEliteDiscount(EliteCustomerStatus status)
        {
            _status = status;
        }

        public decimal ApplyDiscount(decimal total)
        {
            return _status switch
            {
                EliteCustomerStatus.None => total,
                EliteCustomerStatus.Member => total * .95m,
                EliteCustomerStatus.Silver => total * .90m,
                EliteCustomerStatus.Gold => total * .85m,
                _ => total,
            };
        }
    }
}
