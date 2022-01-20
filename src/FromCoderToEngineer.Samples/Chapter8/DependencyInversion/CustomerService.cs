namespace FromCoderToEngineer.Samples.Chapter8.DependencyInversion
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerFactory _customerFactory;

        public CustomerService(ICustomerRepository customerRepository, CustomerFactory customerFactory)
        {
            _customerRepository = customerRepository;
            _customerFactory = customerFactory;
        }

        public void Handle(ChangeCustomerReservationTime request)
        {
            // Handle request in code.
        }
    }
}