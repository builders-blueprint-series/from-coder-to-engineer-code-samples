using System;
using System.Collections.Generic;

namespace FromCoderToEngineer.Samples.Chapter9.GenericDelegates
{
    public class ReservationService
    {
        private readonly IEnumerable<Reservation> _reservations;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservations = reservationRepository.GetAllReservations();
        }

        public T Interact<T>(Func<IEnumerable<Reservation>, T> func)
        {
            return func.Invoke(_reservations);
        }

        public bool Interact(Predicate<IEnumerable<Reservation>> predicate)
        {
            return predicate.Invoke(_reservations);
        }

        public void Interact(Action<IEnumerable<Reservation>> action)
        {
            action.Invoke(_reservations);
        }
    }
}