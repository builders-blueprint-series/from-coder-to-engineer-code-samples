namespace FromCoderToEngineer.Samples.Before
{
    using System;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController()
        {
            _reservationService = new ReservationService();
        }

        [HttpGet]
        public IActionResult GetAllReservations()
        {
            try
            {
                var result = _reservationService.FindAllReservations();

                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpGet("/{min:datetime}/{max:datetime}")]
        public IActionResult GetAllReservationsOnDate(DateTime min, DateTime max)
        {
            if (min == DateTime.MinValue || max == DateTime.MinValue)
            {
                return BadRequest("DateTime must not be default.");
            }

            try
            {
                var result = _reservationService.FindAllReservations(min, max);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpGet("/{id:guid}")]
        public IActionResult FindReservationById(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("Id must not be empty.");
            }

            try
            {
                var result = _reservationService.FindReservationById(id);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }
    }
}
