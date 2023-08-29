using FromCoderToEngineer.Samples.Chapter2.AddingToImplementations;
using System;
using System.Linq;

namespace FromCoderToEngineer.Samples.Chapter2.BadBaseClasses
{
    public class Guest : UpdatedAbstractCustomer
    {
        public Guest()
            : base(EliteCustomerStatus.None, Enumerable.Empty<Reservation>().ToList())
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