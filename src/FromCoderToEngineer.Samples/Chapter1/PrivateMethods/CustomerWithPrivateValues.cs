using System;

namespace FromCoderToEngineer.Samples.Chapter1.PrivateMethods
{
    public class CustomerWithPrivateValues
    {
        private readonly DateTime _availableMinimum;

        private readonly DateTime _availableMaximum;

        public CustomerWithPrivateValues(DateTime minAvailability, DateTime maxAvailability)
        {
            _availableMinimum = minAvailability;
            _availableMaximum = maxAvailability;
        }

        public bool AvailabilityMatchesCustomer(DateTime reservationAvailability)
        {
            return reservationAvailability >= _availableMinimum && reservationAvailability <= _availableMaximum;
        }
    }
}