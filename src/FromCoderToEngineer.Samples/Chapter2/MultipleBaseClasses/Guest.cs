using FromCoderToEngineer.Samples.Chapter2.AddingToImplementations;

namespace FromCoderToEngineer.Samples.Chapter2.MultipleBaseClasses
{
    public class Guest : AbstractCustomer
    {
        public Guest()
            : base(EliteCustomerStatus.None)
        {
        }

        public override decimal ApplyDiscount(decimal total)
        {
            throw new System.NotImplementedException();
        }

        public override void CalculatePointsEarning()
        {
            throw new System.NotImplementedException();
        }

        public override void SendPromotion()
        {
            throw new System.NotImplementedException();
        }
    }
}
