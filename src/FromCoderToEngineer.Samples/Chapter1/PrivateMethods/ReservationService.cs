using System;
using System.Collections.Generic;
using System.Linq;

namespace FromCoderToEngineer.Samples.Chapter1.PrivateMethods
{
    public class ReservationService
    {
        public void FindAvailableCustomers(List<Customer> customers, DateTime availability)
        {
            var fitAvailability = customers.Where(customer => AvailabilityMatchesCustomer(availability, customer.AvailableMinimum, customer.AvailableMaximum));

            // Take a customer and create reservation.
        }

        public void BookReservation(Customer customer, DateTime availability)
        {
            if (AvailabilityMatchesCustomer(availability, customer.AvailableMinimum, customer.AvailableMaximum))
            {
                // Book their reservation.
            }
        }

        private bool AvailabilityMatchesCustomer(DateTime reservationAvailability, DateTime min, DateTime max)
        {
            return reservationAvailability >= min && reservationAvailability <= max;
        }
    }
}