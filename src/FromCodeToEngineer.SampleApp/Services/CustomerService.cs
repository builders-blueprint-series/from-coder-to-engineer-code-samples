namespace FromCodeToEngineer.SampleApp.Services
{
    using System;
    using Infrastructure;
    using Models;
    using Requests;
    using Serilog;

    public class CustomerService
    {
        public CustomerService()
        {
            SmtpService = new SmtpService();
        }

        public static ILogger Logger { get; set; } = Logger.ForContext<CustomerService>();

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

        public void UpdateCustomer(UpdateCustomerEmail request)
        {
            try
            {
                using (var context = new DatabaseContext())
                {
                    var customer = context.Customers.Find(request.CustomerId);

                    if (customer == null)
                    {
                        throw new NullReferenceException("Customer does not exist.");
                    }

                    var oldEmail = customer.Email;

                    customer.Email = request.Email;
                    context.Customers.Update(customer);

                    SmtpService.SendEmail(oldEmail, "Your email has changed from this address.");
                    SmtpService.SendEmail(customer.Email, "Your email has been updated.");
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception, $"Failed update customer {request.CustomerId}");
                throw;
            }
        }
    }
}
