namespace FromCodeToEngineer.SampleApp.Services
{
    using System;
    using Infrastructure;
    using Models;
    using Serilog;

    public class CustomerService
    {
        public CustomerService()
        {
            SmtpService = new SmtpService();
            Logger = Logger.ForContext<CustomerService>();
        }

        public static ILogger Logger { get; set; }

        public SmtpService SmtpService { get; set; }

        public Customer AddCustomer(string firstName, string lastName, string email)
        {
            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Email = email,
            };

            int wasSuccessful;

            using (var context = new DatabaseContext())
            {
                context.Customers.Add(customer);
                wasSuccessful = context.SaveChanges();
            }

            if (wasSuccessful == 1)
            {
                SmtpService.SendEmail(email, "Thanks for signing up!");
                return customer;
            }

            Logger.Error("Couldn't create customer");
            throw new Exception("Customer was not saved correctly.");
        }
    }
}
