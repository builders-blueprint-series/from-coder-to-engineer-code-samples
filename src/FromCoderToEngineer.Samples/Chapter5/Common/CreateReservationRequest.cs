using System;

namespace FromCoderToEngineer.Samples.Chapter5.Common
{
    public class CreateReservationRequest
    {
        public Guid CustomerId { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
