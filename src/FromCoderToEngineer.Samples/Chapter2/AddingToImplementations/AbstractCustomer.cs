namespace FromCoderToEngineer.Samples.Chapter2.AddingToImplementations
{
    public abstract class AbstractCustomer
    {
        protected readonly EliteCustomerStatus Status;

        protected AbstractCustomer(EliteCustomerStatus status)
        {
            Status = status;
        }

        public abstract decimal ApplyDiscount(decimal total);

        public abstract void CalculatePointsEarning();

        public abstract void SendPromotion();
    }
}
