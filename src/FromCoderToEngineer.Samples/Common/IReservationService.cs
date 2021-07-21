namespace FromCoderToEngineer.Samples.Common
{
    using System;
    using System.Collections.Generic;

    public interface IReservationService
    {
        IEnumerable<Reservation> FindAllReservations();

        IEnumerable<Reservation> FindAllReservationsOnDate(DateTime datetime);

        IEnumerable<Reservation> FindAllReservationsOnDate(DateTime min, DateTime max);

        IEnumerable<Reservation> FindAllReservationsOnDate(FindAllReservationsInRange request);
    }
}
