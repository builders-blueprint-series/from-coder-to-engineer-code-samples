using System.Collections.Generic;

namespace FromCoderToEngineer.Samples.Chapter9.GenericDelegates
{
    public interface IReservationRepository
    {
        IReadOnlyList<Reservation> GetAllReservations();
    }
}