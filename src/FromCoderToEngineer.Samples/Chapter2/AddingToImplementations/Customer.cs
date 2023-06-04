namespace FromCoderToEngineer.Samples.Chapter2.AddingToImplementations
{
    public class Customer
    {
        private readonly CustomerStatus _status;

        public Customer(CustomerStatus status)
        {
            _status = status;
        }

        public decimal ApplyDiscount(decimal total)
        {
            if (_status == CustomerStatus.Member)
            {
                const decimal discount = .95m;

                return total * discount;
            }

            return total;
        }
    }
}
