using FromCoderToEngineer.Samples.Chapter5.Common;

namespace FromCoderToEngineer.Samples.Chapter5.GodClasses
{
    public class ReservationService : IReservationService
    {
        private readonly ISmtpClient _smtpClient;
        private readonly ICustomerRepository _customerRepository;
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(ISmtpClient smtpClient, ICustomerRepository customerRepository, IReservationRepository reservationRepository)
        {
            _smtpClient = smtpClient;
            _customerRepository = customerRepository;
            _reservationRepository = reservationRepository;
        }

        public ReservationResult CreateReservation(CreateReservationRequest request)
        {
            var reservation = ReservationFactory.FromRequest(request);

            var addResult = _reservationRepository.AddReservation(reservation);

            var customer = _customerRepository.FindById(request.CustomerId);

            if (addResult)
            {
                _smtpClient.SendEmail(customer.Email, "Reservation Success", $"Your reservation is confirmed for {request.Timestamp}.");
            }

            return ReservationFactory.ReservationResult(addResult, customer);
        }
    }
}
