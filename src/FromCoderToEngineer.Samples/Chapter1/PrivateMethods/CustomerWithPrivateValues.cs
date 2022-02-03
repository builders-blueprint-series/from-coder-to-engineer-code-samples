using System;

namespace FromCoderToEngineer.Samples.Chapter1.PrivateMethods
{
    public class CustomerWithPrivateValues
    {
        // Other properties and methods omitted for brevity.

        private readonly DateTime _availableMinimum;

        private readonly DateTime _availableMaximum;

        public bool AvailabilityMatchesCustomer(DateTime reservationAvailability)
        {
            return reservationAvailability >= _availableMinimum && reservationAvailability <= _availableMaximum;
        }
    }
}