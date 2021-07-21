namespace FromCoderToEngineer.Samples.Chapter8.TheNewKeyword.UpdatingOurUseCase
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

        [HttpGet("/{min:datetime}/{max:datetime}")]
        public IActionResult FindAllReservationsOnDate(DateTime min, DateTime max)
        {
            if (min == DateTime.MinValue || max == DateTime.MinValue)
            {
                return BadRequest();
            }

            try
            {
                var result = _reservationService.FindAllReservationsOnDate(min, max);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }
    }
}
