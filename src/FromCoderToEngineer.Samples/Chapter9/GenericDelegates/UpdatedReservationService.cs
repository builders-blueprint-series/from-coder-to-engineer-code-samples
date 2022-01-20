using System;
using System.Collections.Generic;

namespace FromCoderToEngineer.Samples.Chapter9.GenericDelegates
{
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