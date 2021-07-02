namespace FromCoderToEngineer.Samples.Common.ReservationService
{
    public interface IReservationService
    {
        FindAllReservationsResponse FindAllReservations();

        FindAllReservationsOnDateResponse FindAllReservationsOnDate(FindAllReservationsOnDate request);

        void ChangeReservationTime(ChangeReservationTime request);
    }
}
