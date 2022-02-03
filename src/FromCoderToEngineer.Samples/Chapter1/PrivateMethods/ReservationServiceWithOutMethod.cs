using System;
using System.Collections.Generic;
using System.Linq;

namespace FromCoderToEngineer.Samples.Chapter1.PrivateMethods
{
    public class ReservationServiceWithOutMethod
    {
        public void FindAvailableCustomers(List<CustomerWithAvailabilityMethod> customers, DateTime availability)
        {
            var fitAvailability = customers.Where(customer => customer.AvailabilityMatchesCustomer(availability, customer.AvailableMinimum, customer.AvailableMaximum));

            // Take a customer and create reservation.
        }

        public void BookReservation(CustomerWithAvailabilityMethod customer, DateTime availability)
        {
            if (customer.AvailabilityMatchesCustomer(availability, customer.AvailableMinimum, customer.AvailableMaximum))
            {
                // Book their reservation.
            }
        }
    }
}