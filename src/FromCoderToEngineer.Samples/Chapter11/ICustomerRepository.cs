namespace FromCoderToEngineer.Samples.Chapter11
{
    using System;
    using System.Collections.Generic;

    public interface ICustomerRepository
    {
        Customer GetById(Guid id);

        void AddCustomer(Customer customer);

        List<Customer> GetAllCustomers();

        void UpdateCustomer(Customer customer);
    }
}
