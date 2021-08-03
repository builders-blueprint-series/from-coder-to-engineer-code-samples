namespace FromCodeToEngineer.SampleApp.Requests
{
    using System;

    public class AddReservation
    {
        public Guid CustomerId { get; set; }

        public DateTime DateTime { get; set; }
    }
}
