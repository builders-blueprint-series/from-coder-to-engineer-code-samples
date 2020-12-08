namespace FromCoderToEngineer.API.Controllers
{
    using FromCoderToEngineer.Application.Contracts;
    using FromCoderToEngineer.Application.Reservations;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController()
        {
            var serviceLocator = new ServiceLocator.ServiceLocator();

            _reservationService = serviceLocator.GetService<IReservationService>();
        }

        [HttpPost]
        public bool CreateReservation([FromBody] CreateReservationRequest request)
        {
            if (request.PartySize <= 0)
            {
                return false;
            }

            var result = _reservationService.CreateReservation(request.Name, request.PartySize, request.ReservationTime);

            return result;
        }
    }
}
