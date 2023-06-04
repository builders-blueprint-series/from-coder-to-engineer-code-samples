using FromCoderToEngineer.Samples.Chapter2.AddingToImplementations;
using System.Collections.Generic;

namespace FromCoderToEngineer.Samples.Chapter2.BadBaseClasses
{
    public abstract class UpdatedAbstractCustomer
    {
        protected readonly EliteCustomerStatus Status;

        private readonly List<Reservation> _pastReservations;

        protected UpdatedAbstractCustomer(EliteCustomerStatus status, List<Reservation> pastReservations)
        {
            Status = status;
            _pastReservations = pastReservations;
        }

        public int PastReservationsCount => _pastReservations.Count;

        public abstract decimal ApplyDiscount(decimal total);

        public abstract void CalculatePointsEarning();

        public abstract void SendPromotion();
    }
}
