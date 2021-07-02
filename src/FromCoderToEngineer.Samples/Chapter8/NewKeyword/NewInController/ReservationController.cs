using FromCoderToEngineer.Samples.Common.ReservationService;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FromCoderToEngineer.Samples.Chapter8.NewKeyword.NewInController
{
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
                return BadRequest(exception.Message);
            }
        }

        [HttpGet("/{date:datetime}")]
        public IActionResult FindAllReservationsOnDate(DateTime date)
        {
            var request = new FindAllReservationsOnDate(date);

            var result = _reservationService.FindAllReservationsOnDate(request);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult ChangeReservationTime(ChangeReservationTime request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _reservationService.ChangeReservationTime(request);

            return Accepted();
        }
    }
}
