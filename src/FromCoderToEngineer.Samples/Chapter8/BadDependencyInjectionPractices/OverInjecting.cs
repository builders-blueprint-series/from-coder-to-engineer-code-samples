using FromCoderToEngineer.Samples.Chapter8.DependencyInversion;

namespace FromCoderToEngineer.Samples.Chapter8.BadDependencyInjectionPractices
{
    public class OverInjecting : ICustomerService
    {
        private readonly IEventBus _eventBus;
        private readonly ISystemClock _systemClock;
        private readonly IReservationService _reservationService;
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerFactory _customerFactory;

        public OverInjecting(IEventBus eventBus, ISystemClock systemClock, IReservationService reservationService, ICustomerRepository customerRepository, CustomerFactory customerFactory)
        {
            _eventBus = eventBus;
            _systemClock = systemClock;
            _reservationService = reservationService;
            _customerRepository = customerRepository;
            _customerFactory = customerFactory;
        }

        public void Handle(ChangeCustomerReservationTime request)
        {
            // Handle the request.
        }
    }
}
