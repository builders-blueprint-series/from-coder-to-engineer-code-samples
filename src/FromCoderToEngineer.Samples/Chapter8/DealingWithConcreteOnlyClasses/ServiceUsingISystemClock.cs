﻿using FromCoderToEngineer.Samples.Chapter8.DependencyInversion;
using System;

namespace FromCoderToEngineer.Samples.Chapter8.DealingWithConcreteOnlyClasses
{
    public class ServiceUsingISystemClock : ICustomerService
    {
        private readonly ISystemClock _clock;

        public ServiceUsingISystemClock(ISystemClock clock)
        {
            _clock = clock;
        }

        public void Handle(ChangeCustomerReservationTime request)
        {
            if (request.DateTime < _clock.Now())
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}