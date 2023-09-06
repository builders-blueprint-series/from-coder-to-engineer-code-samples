namespace FromCoderToEngineer.Samples.Chapter5.Common
{
    public static class ReservationFactory
    {
        public static Reservation FromRequest(CreateReservationRequest request)
        {
            return new Reservation();
        }

        public static ReservationResult ReservationResult(bool success, Customer customer)
        {
            return new ReservationResult();
        }
    }
}
