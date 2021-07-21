namespace FromCoderToEngineer.Samples.Common
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class FindAllReservationsInRange
    {
        public FindAllReservationsInRange(DateTime min, DateTime max)
        {
            Min = min;
            Max = max;
        }

        public DateTime Min { get; }

        public DateTime Max { get; }
    }
}
