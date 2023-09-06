using System;

namespace FromCoderToEngineer.Samples.Chapter5.GodClasses
{
    public class ReservationCreated : INotification
    {
        public ReservationCreated(Guid customerId, DateTime timestamp)
        {
            CustomerId = customerId;
            Timestamp = timestamp;
        }

        public Guid CustomerId { get; }

        public DateTime Timestamp { get; }
    }
}
