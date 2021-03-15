namespace FromCoderToEngineer.Samples.Chapter9.GenericDelegates
{
    using System;
    using System.Collections.Generic;

    public class UpdatedReservationService : IInteract<Reservation>
    {
        private readonly IEnumerable<Reservation> _reservations;

        public UpdatedReservationService(IReservationRepository reservationRepository)
        {
            _reservations = reservationRepository.GetAllReservations();
        }

        public TResult Interact<TResult>(Func<IEnumerable<Reservation>, TResult> func)
        {
            return func.Invoke(_reservations);
        }
    }
}
