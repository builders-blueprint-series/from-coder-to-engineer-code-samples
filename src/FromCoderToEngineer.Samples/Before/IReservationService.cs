namespace FromCoderToEngineer.Samples.Before
{
    using System;
    using System.Collections.Generic;

    public interface IReservationService
    {
        IEnumerable<Reservation> FindAllReservations();

        IEnumerable<Reservation> FindAllReservations(DateTime min, DateTime max);

        Reservation FindReservationById(Guid id);

        void AddReservation(DateTime dateTime, Guid customerId);
    }
}
