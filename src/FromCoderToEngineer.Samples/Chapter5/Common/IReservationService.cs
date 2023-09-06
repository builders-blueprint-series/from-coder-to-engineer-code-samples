namespace FromCoderToEngineer.Samples.Chapter5.Common
{
    public interface IReservationService
    {
        ReservationResult CreateReservation(CreateReservationRequest request);
    }
}
