namespace FromCodeToEngineer.SampleApp.Requests
{
    using System;

    public class UpdateCustomerEmail
    {
        public Guid CustomerId { get; set; }

        public string Email { get; set; }
    }
}
