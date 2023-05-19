using System;

namespace FromCoderToEngineer.Samples.Chapter1.PrivateMethods
{
    public class CustomerWithAvailabilityMethod
    {
        // Other properties and method omitted for brevity.

        public DateTime AvailableMinimum { get; }

        public DateTime AvailableMaximum { get; }

        public bool AvailabilityMatchesCustomer(DateTime reservationAvailability, DateTime min, DateTime max)
        {
            return reservationAvailability >= min && reservationAvailability <= max;
        }
    }
}