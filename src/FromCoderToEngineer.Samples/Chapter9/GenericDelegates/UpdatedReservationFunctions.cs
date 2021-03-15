namespace FromCoderToEngineer.Samples.Chapter9.GenericDelegates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FromCoderToEngineer.Samples.Chapter9.CommonInterfaces;

    public class UpdatedReservationFunctions
    {
        public static Func<IEnumerable<Reservation>, IEnumerable<Reservation>> TodaysReservations = x => x.Where(y => y.DateTime == DateTime.Today);

        public static Func<IEnumerable<Reservation>, bool> RestaurantIsFull = x => x.Count() == 100;

        public static Func<IEnumerable<Reservation>, Unit> CloseOldReservations = x =>
            {
                x.Where(y => y.DateTime <= DateTime.Today).ToList().ForEach(y => y.Close());
                return Unit.Value;
            };
    }
}
