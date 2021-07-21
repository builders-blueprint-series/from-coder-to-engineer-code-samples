namespace FromCoderToEngineer.Samples.Chapter8.NewKeyword.NewInController
{
    using System;
    using FromCoderToEngineer.Samples.Common.ReservationService;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    //[ApiController]
    //[Route("api/[controller]")]
    //public class ReservationController : ControllerBase
    //{
    //    private readonly IReservationService _reservationService;

    //    public ReservationController()
    //    {
    //        _reservationService = new ReservationService();
    //    }

    //    [HttpGet]
    //    public IActionResult GetAllReservations()
    //    {
    //        try
    //        {
    //            var result = _reservationService.FindAllReservations();

    //            return Ok(result);
    //        }
    //        catch (Exception exception)
    //        {
    //            return BadRequest(exception.Message);
    //        }
    //    }

    //    [HttpGet("/{date:datetime}")]
    //    public IActionResult FindAllReservationsOnDate(DateTime date)
    //    {
    //        var request = new FindAllReservationsOnDate(date);

    //        var result = _reservationService.FindAllReservationsOnDate(request);

    //        return Ok(result);
    //    }

    //    [HttpPost]
    //    public IActionResult ChangeReservationTime(ChangeReservationTime request)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest();
    //        }

    //        _reservationService.ChangeReservationTime(request);

    //        return Accepted();
    //    }
    //}

    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
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
                return BadRequest(exception.Message);
            }
        }

        //[HttpGet("/{min:datetime}/{max:datetime}")]
        //public IActionResult FindAllReservationsOnDate(DateTime min, DateTime max)
        //{
        //    if (min == DateTime.MinValue || max == DateTime.MinValue)
        //    {
        //        return BadRequest();
        //    }

        //    try
        //    {
        //        var result = _reservationService.FindAllReservationsOnDate(min, max);

        //        return Ok(result);
        //    }
        //    catch (Exception exception)
        //    {
        //        return BadRequest(exception.Message);
        //    }
        //}

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
