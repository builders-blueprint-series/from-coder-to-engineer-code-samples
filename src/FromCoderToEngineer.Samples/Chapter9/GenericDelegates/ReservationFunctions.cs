﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FromCoderToEngineer.Samples.Chapter9.GenericDelegates
{
    public class ReservationFunctions
    {
        public static Func<IEnumerable<Reservation>, IEnumerable<Reservation>> TodaysReservations = x => x.Where(y => y.DateTime == DateTime.Today);

        public static Predicate<IEnumerable<Reservation>> RestaurantIsFull = x => x.Count() == 100;

        public static Action<IEnumerable<Reservation>> CloseOldReservations =
            x => x.Where(y => y.DateTime <= DateTime.Today).ToList().ForEach(y => y.Close());
    }
}