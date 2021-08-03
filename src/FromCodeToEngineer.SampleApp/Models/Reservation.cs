namespace FromCodeToEngineer.SampleApp.Models
{
    using System;

    public class Reservation
    {
        public Guid Id { get; set; }

        public DateTime DateTime { get; set; }

        public Customer Customer { get; set; }
    }
}
