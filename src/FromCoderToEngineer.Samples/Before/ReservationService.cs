using FromCoderToEngineer.Samples.Chapter8.DependencyInversion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FromCoderToEngineer.Samples.Before
{
    public class ReservationService : IReservationService
    {
        private readonly 


        public IEnumerable<Reservation> FindAllReservations()
        {
            using (var context = new ReservationContext())
            {

            }
        }

        public IEnumerable<Reservation> FindAllReservations(DateTime min, DateTime max)
        {
            throw new NotImplementedException();
        }

        public Reservation FindReservationById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void AddReservation(DateTime dateTime, Guid customerId)
        {
            var reservation = new Reservation { Id = Guid.NewGuid(), CustomerId = customerId, DateTime = dateTime };


        }
    }
}
