namespace FromCoderToEngineer.Samples.Chapter8.TheNewKeyword.NewForServices
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
    }
}
