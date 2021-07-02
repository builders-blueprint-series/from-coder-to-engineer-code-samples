using System;

namespace FromCoderToEngineer.Samples.Common.ReservationService
{
    public class FindAllReservationsOnDate
    {
        public FindAllReservationsOnDate(DateTime dateTime)
        {
            DateTime = dateTime;
        }

        public DateTime DateTime { get; }
    }
}
