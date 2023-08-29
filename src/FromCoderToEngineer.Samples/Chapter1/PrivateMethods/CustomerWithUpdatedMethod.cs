using System;

namespace FromCoderToEngineer.Samples.Chapter1.PrivateMethods
{
    public class CustomerWithUpdatedMethod
    {
        // Other properties and method omitted for brevity.
        public DateTime AvailableMinimum { get; }

        public DateTime AvailableMaximum { get; }

        public bool AvailabilityMatchesCustomer(DateTime reservationAvailability)
        {
            return reservationAvailability >= AvailableMinimum && reservationAvailability <= AvailableMaximum;
        }
    }
}