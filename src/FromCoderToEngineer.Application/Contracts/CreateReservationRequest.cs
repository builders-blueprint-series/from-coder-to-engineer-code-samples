namespace FromCoderToEngineer.Application.Contracts
{
    using System;

    public class CreateReservationRequest
    {
        public string Name { get; set; }

        public int PartySize { get; set; }

        public DateTime ReservationTime { get; set; }
    }
}
