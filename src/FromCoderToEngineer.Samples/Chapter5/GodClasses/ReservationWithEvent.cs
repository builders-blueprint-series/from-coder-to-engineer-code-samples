using System;

namespace FromCoderToEngineer.Samples.Chapter5.GodClasses
{
    public class ReservationWithEvent : Entity
    {
        public Guid Id { get; set; }

        public ReservationWithEvent()
        {
            AddNotification(new ReservationCreated());
        }
    }
}
