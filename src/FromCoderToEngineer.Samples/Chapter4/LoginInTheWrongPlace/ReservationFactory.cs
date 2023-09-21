namespace FromCoderToEngineer.Samples.Chapter4.LoginInTheWrongPlace
{
    public static class ReservationFactory
    {
        public static ReservationResponse FromReservation(Reservation reservation)
        {
            return new ReservationResponse();
        }

        public static ReservationResponse EmptyResponse()
        {

        }
    }
}
