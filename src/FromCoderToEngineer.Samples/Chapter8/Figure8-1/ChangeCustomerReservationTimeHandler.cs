using FromCoderToEngineer.Samples.Chapter9.GenrricDelegates;

namespace FromCoderToEngineer.Samples.Chapter8
{
    public class ChangeCustomerReservationTimeHandler : IHandleRequest<ChangeCustomerReservationTime>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerFactory _customerFactory;

        public ChangeCustomerReservationTimeHandler(ICustomerRepository customerRepository, CustomerFactory customerFactory)
        {
            _customerRepository = customerRepository;
            _customerFactory = customerFactory;
        }

        public Unit Handle(ChangeCustomerReservationTime request)
        {
            // Handle request in code.

            return Unit.Value;
        }
    }
}
