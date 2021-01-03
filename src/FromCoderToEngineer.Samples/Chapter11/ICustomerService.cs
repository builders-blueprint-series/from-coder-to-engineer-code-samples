namespace FromCoderToEngineer.Samples.Chapter11
{
    using System;
    using System.Collections.Generic;

    public interface ICustomerService
    {
        void AddLoyaltyPoints(Guid customerId, int loyaltyPoints);

        void GiftPoints(Guid customerId, int loyaltyPoints);

        Customer CreateCustomer(string firstName, string lastName, string email);

        Customer StatusMatchCustomer(string firstName, string lastName, string email, LoyaltyStatus status);

        IEnumerable<Customer> GetAllSilverCustomers();
    }
}
