namespace FromCoderToEngineer.Samples.Chapter8.TheNewKeyword.PassingArgumentsToAService
{
    using System;
    using Common;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("/{date:datetime}")]
        public IActionResult FindAllReservationsOnDate(DateTime date)
        {
            if (date == DateTime.MinValue)
            {
                return BadRequest();
            }

            try
            {
                var result = _reservationService.FindAllReservationsOnDate(date);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }
    }
}
