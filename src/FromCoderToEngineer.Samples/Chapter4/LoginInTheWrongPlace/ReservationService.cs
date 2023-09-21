using Microsoft.AspNetCore.Http;
using System;

namespace FromCoderToEngineer.Samples.Chapter4.LoginInTheWrongPlace
{
    public class ReservationService
    {
        private readonly IReservationRepository _repository;

        public ReservationService(IReservationRepository repository)
        {
            _repository = repository;
        }

        public int DeleteReservation(Guid id)
        {
            var success = _repository.DeleteReservation(id);

            if (success)
            {
                return StatusCodes.Status204NoContent;
            }

            return StatusCodes.Status500InternalServerError;
        }
    }
}
