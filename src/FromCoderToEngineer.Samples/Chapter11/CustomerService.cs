namespace FromCoderToEngineer.Samples.Chapter11
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmailClient _emailClient;

        public CustomerService(ICustomerRepository customerRepository, IEmailClient emailClient)
        {
            _customerRepository = customerRepository;
            _emailClient = emailClient;
        }

        public void AddLoyaltyPoints(Guid customerId, int loyaltyPoints)
        {
            var customer = _customerRepository.GetById(customerId);

            var newStatus = AddPointsAndCheckForNewStatus(customer, loyaltyPoints);

            if (newStatus)
            {
                _emailClient.SendNewStatusEmail(customer);
            }
        }

        public void GiftPoints(Guid customerId, int loyaltyPoints)
        {
            var customer = _customerRepository.GetById(customerId);

            AddPointsAndCheckForNewStatus(customer, loyaltyPoints);

            _emailClient.SendApology(customer);
        }

        public Customer CreateCustomer(string firstName, string lastName, string email)
        {
            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                LoyaltyPoints = 0,
                PointsYearToDate = 0,
                Status = LoyaltyStatus.Blue,
            };

            customer.LoyaltyId = customer.Id.GenerateCustomerId();

            _customerRepository.AddCustomer(customer);

            return customer;
        }

        public Customer StatusMatchCustomer(string firstName, string lastName, string email, LoyaltyStatus status)
        {
            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                LoyaltyPoints = 0,
                PointsYearToDate = 0,
                Status = status,
            };

            customer.LoyaltyId = customer.Id.GenerateCustomerId();

            _customerRepository.AddCustomer(customer);

            return customer;
        }

        public IEnumerable<Customer> GetAllSilverCustomers()
        {
            var allCustomers = _customerRepository.GetAllCustomers();

            return allCustomers.Where(customer => customer.Status == LoyaltyStatus.Silver);
        }

        private bool AddPointsAndCheckForNewStatus(Customer customer, int points)
        {
            var currentStatus = customer.Status;

            customer.LoyaltyPoints += points;
            customer.PointsYearToDate += points;

            if (customer.PointsYearToDate >= 25000)
            {
                customer.Status = LoyaltyStatus.Silver;
            }

            if (customer.PointsYearToDate >= 50000)
            {
                customer.Status = LoyaltyStatus.Gold;
            }

            if (customer.PointsYearToDate >= 75000)
            {
                customer.Status = LoyaltyStatus.Platinum;
            }

            if (currentStatus != customer.Status)
            {
                return true;
            }

            return false;
        }
    }
}
