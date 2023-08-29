namespace FromCoderToEngineer.Samples.Chapter2.AddingToImplementations
{
    internal class ComplexCustomer
    {
        private readonly EliteCustomerStatus _status;

        public ComplexCustomer(EliteCustomerStatus status)
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

        public void CalculatePointsEarning()
        {
            // Logic removed for brevity.
        }

        public void SendPromotion()
        {
            // Logic removed for brevity.
        }
    }
}