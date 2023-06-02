namespace FromCoderToEngineer.Samples.Common.ReservationService
{
    using System;

    public class FindAllReservationsOnDate
    {
        public FindAllReservationsOnDate(DateTime dateTime)
        {
            DateTime = dateTime;
        }

        public DateTime DateTime { get; }
    }
}