using System;

namespace FromCoderToEngineer.Samples.Chapter4.LoginInTheWrongPlace
{
    public interface IReservationRepository
    {
        Reservation GetById(Guid id);

        bool DeleteReservation(Guid id);
    }
}
