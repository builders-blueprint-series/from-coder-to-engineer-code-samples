using FromCoderToEngineer.Samples.Chapter9.GenericDelegates;
using System;
using System.Collections.Generic;

namespace FromCoderToEngineer.Samples.Common.ReservationService
{
    public class ReservationService : IReservationService
    {
        public void ChangeReservationTime(ChangeReservationTime request)
        {
            throw new NotImplementedException();
        }

        public FindAllReservationsResponse FindAllReservations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> FindAllReservationsOnDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> FindAllReservationsOnDate(DateTime min, DateTime max)
        {
            throw new NotImplementedException();
        }

        public FindAllReservationsOnDateResponse FindAllReservationsOnDate(FindAllReservationsOnDate request)
        {
            throw new NotImplementedException();
        }
    }
}