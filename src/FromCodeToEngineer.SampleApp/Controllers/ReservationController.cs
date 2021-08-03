namespace FromCodeToEngineer.SampleApp.Controllers
{
    using System;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Requests;
    using Services;

    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        public ReservationController()
        {
            ReservationService = new ReservationService();
        }

        public ReservationService ReservationService { get; set; }

        [HttpGet]
        public IActionResult AllReservations()
        {
            try
            {
                var result = ReservationService.GetAllReservations();

                return Ok(result);
            }
            catch (Exception exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{min:datetime}/{max:datetime}")]
        public IActionResult GetReservationsInRange(DateTime min, DateTime max)
        {
            if (min == DateTime.MinValue || max == DateTime.MinValue)
            {
                return BadRequest("DateTime must not be a default value.");
            }

            try
            {
                var result = ReservationService.GetAllReservations(min, max);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public IActionResult AddReservation(AddReservation request)
        {
            try
            {
                var result = ReservationService.AddReservation(request);

                return Created(string.Empty, result);
            }
            catch (Exception exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteReservation(Guid id)
        {
            try
            {
                ReservationService.DeleteReservation(id);

                return NoContent();
            }
            catch (Exception exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
