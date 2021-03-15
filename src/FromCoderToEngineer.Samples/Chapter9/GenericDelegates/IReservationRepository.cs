namespace FromCoderToEngineer.Samples.Chapter9.GenericDelegates
{
    using System.Collections.Generic;

    public interface IReservationRepository
    {
        IReadOnlyList<Reservation> GetAllReservations();
    }
}
