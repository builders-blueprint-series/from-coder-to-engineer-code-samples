using System;
using System.Collections.Generic;
using System.Linq;

namespace FromCoderToEngineer.Samples.Chapter1.PrivateMethods
{
    public class ReservationServiceWithUpdateMethodCalls
    {
        public void FindAvailableCustomers(List<CustomerWithUpdatedMethod> customers, DateTime availability)
        {
            var fitAvailability = customers.Where(customer => customer.AvailabilityMatchesCustomer(availability));

            // Take a customer and create reservation.
        }

        public void BookReservation(CustomerWithUpdatedMethod customer, DateTime availability)
        {
            if (customer.AvailabilityMatchesCustomer(availability))
            {
                // Book their reservation.
            }
        }
    }
}