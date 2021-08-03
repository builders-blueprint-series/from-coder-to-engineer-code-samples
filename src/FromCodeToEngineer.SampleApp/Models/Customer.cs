namespace FromCodeToEngineer.SampleApp.Models
{
    using System;

    public class Customer
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Status Status { get; set; }

        public int TotalReservations { get; set; }
    }
}
