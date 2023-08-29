using System;

namespace FromCoderToEngineer.Samples.Chapter2.AddingToImplementations
{
    public class SilverCustomer : AbstractCustomer
    {
        public SilverCustomer()
            : base(EliteCustomerStatus.Silver)
        {
        }

        public override decimal ApplyDiscount(decimal total)
        {
            throw new NotImplementedException();
        }

        public override void CalculatePointsEarning()
        {
            throw new NotImplementedException();
        }

        public override void SendPromotion()
        {
            throw new NotImplementedException();
        }
    }
}