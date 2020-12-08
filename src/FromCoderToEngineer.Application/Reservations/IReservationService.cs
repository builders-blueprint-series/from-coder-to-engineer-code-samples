namespace FromCoderToEngineer.Application.Reservations
{
    using System;

    public interface IReservationService
    {
        bool CreateReservation(string name, int partySize, DateTime reservationTime);
    }
}
