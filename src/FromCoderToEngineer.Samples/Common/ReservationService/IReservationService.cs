namespace FromCoderToEngineer.Samples.Common.ReservationService
{
    using System;
    using System.Collections.Generic;
    using FromCoderToEngineer.Samples.Chapter9.GenericDelegates;

    public interface IReservationService
    {
        FindAllReservationsResponse FindAllReservations();

        IEnumerable<Reservation> FindAllReservationsOnDate(DateTime dateTime);

        IEnumerable<Reservation> FindAllReservationsOnDate(DateTime min, DateTime max);

        FindAllReservationsOnDateResponse FindAllReservationsOnDate(FindAllReservationsOnDate request);

        void ChangeReservationTime(ChangeReservationTime request);
    }
}