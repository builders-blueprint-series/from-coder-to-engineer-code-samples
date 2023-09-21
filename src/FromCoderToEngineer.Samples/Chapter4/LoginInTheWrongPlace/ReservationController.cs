using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FromCoderToEngineer.Samples.Chapter4.LoginInTheWrongPlace
{
    [Route("[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationRepository _repository;

        public ReservationController(IReservationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet(Name = "GetReservationById")]
        [ProducesResponseType(typeof(ReservationResponse), StatusCodes.Status200OK)]
        public IActionResult ReservationById(Guid id)
        {
            var reservation = _repository.GetById(id);

            var response = ReservationFactory.FromReservation(reservation);

            return Ok(response);
        }
    }
}
